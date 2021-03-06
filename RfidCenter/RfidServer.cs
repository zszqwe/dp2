﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using DigitalPlatform;
using DigitalPlatform.RFID;
using DigitalPlatform.Text;

namespace RfidCenter
{
    public class RfidServer : MarshalByRefObject, IRfid, IDisposable
    {
        public void Dispose()
        {
            _cancelInventory?.Cancel();
        }

        // 列出当前可用的 reader
        public ListReadersResult ListReaders()
        {
            // 选出已经成功打开的部分 Reader 返回
            List<string> readers = new List<string>();
            foreach (Reader reader in Program.Rfid.Readers)
            {
                if (reader.Result.Value == 0)
                    readers.Add(reader.Name);
            }
            return new ListReadersResult { Readers = readers.ToArray() };
        }

        public ListTagsResult ListTags(string reader_name)
        {
            InventoryResult result = new InventoryResult();
            List<OneTag> tags = new List<OneTag>();

            foreach (Reader reader in Program.Rfid.Readers)
            {
                if (reader_name == "*" || reader.Name == reader_name)
                {

                }
                else
                    continue;

                InventoryResult inventory_result = Program.Rfid.Inventory(reader.Name, "");
                if (inventory_result.Value == -1)
                {
                    return new ListTagsResult { Value = -1, ErrorInfo = inventory_result.ErrorInfo };
                }

                foreach (InventoryInfo info in inventory_result.Results)
                {
                    tags.Add(new OneTag
                    {
                        ReaderName = reader.Name,
                        UID = info.UID,
                        DSFID = info.DsfID
                    });

#if NO
                            GetTagInfoResult result0 = Program.Rfid.GetTagInfo(reader.Name, info);
                            if (result0.Value == -1)
                            {
                                // TODO: 如何报错？写入操作历史?
                                Program.MainForm.OutputText($"读取标签{info.UID}信息时出错:{result0.ToString()}", 2);
                                continue;
                            }

                            LogicChip chip = LogicChip.From(result0.TagInfo.Bytes,
                                (int)result0.TagInfo.BlockSize,
                                "" // result0.TagInfo.LockStatus
                                );
                            Element pii = chip.FindElement(ElementOID.PII);
                            if (pii == null)
                            {
                                Program.MainForm.Invoke((Action)(() =>
                                {
                                    // 发送 UID
                                    SendKeys.SendWait($"uid:{info.UID}\r");
                                }));
                            }
                            else
                            {
                                Program.MainForm.Invoke((Action)(() =>
                                {
                                    // 发送 PII
                                    SendKeys.SendWait($"pii:{pii.Text}\r");
                                }));
                            }
#endif
                }
            }

            return new ListTagsResult { Results = tags };

#if NO
            InventoryResult result = new InventoryResult();
            List<OneTag> tags = new List<OneTag>();
            _lockTagList.EnterReadLock();
            try
            {
                foreach (OneTag tag in _tagList)
                {
                    if (reader_name == "*" || tag.ReaderName == reader_name)
                        tags.Add(tag);
                }
                return new ListTagsResult { Results = tags };
            }
            finally
            {
                _lockTagList.ExitReadLock();
            }
#endif
        }

        public GetTagInfoResult GetTagInfo(string reader_name,
            string uid)
        {
            foreach (Reader reader in Program.Rfid.Readers)
            {
                if (reader_name == "*" || reader.Name == reader_name)
                {

                }
                else
                    continue;

                InventoryInfo info = new InventoryInfo { UID = uid };
                GetTagInfoResult result0 = Program.Rfid.GetTagInfo(reader.Name, info);

                if (result0.Value == -1 && result0.ErrorCode == "errorFromReader=4")
                    continue;

                if (result0.Value == -1)
                    return result0;

                // not found
                return result0;
            }

            return new GetTagInfoResult();
        }

        public NormalResult WriteTagInfo(
    string reader_name,
    TagInfo old_tag_info,
    TagInfo new_tag_info)
        {
            // TODO: 对 old_tag_info 和 new_tag_info 合法性进行一系列检查

            foreach (Reader reader in Program.Rfid.Readers)
            {
                if (reader_name == "*" || reader.Name == reader_name)
                {

                }
                else
                    continue;

                InventoryInfo info = new InventoryInfo
                {
                    UID = old_tag_info.UID
                };
                GetTagInfoResult result0 = Program.Rfid.GetTagInfo(reader.Name, info);

                if (result0.Value == -1 && result0.ErrorCode == "errorFromReader=4")
                    continue;

                if (result0.Value == -1)
                    return new NormalResult(result0);

                // TODO: 是否对照检查 old_tag_info 和 result0.TagInfo ?

                return Program.Rfid.WriteTagInfo(reader.Name,
                    old_tag_info,
                    new_tag_info);
            }

            return new NormalResult
            {
                Value = -1,
                ErrorInfo = $"没有找到 UID 为 {old_tag_info.UID} 的标签",
                ErrorCode = "notFound"
            };
        }

        // parameters:
        //      reader_name 读卡器名字。也可以为 "*"，表示所有读卡器
        //      tag_name    标签名字。为 pii:xxxx 或者 uid:xxxx 形态。若没有冒号，则默认为是 UID
        // return result.Value:
        //      -1  出错
        //      0   没有找到指定的标签
        //      1   找到，并成功修改 EAS
        public NormalResult SetEAS(
string reader_name,
string tag_name,
bool enable)
        {
            string uid = "";
            List<string> parts = StringUtil.ParseTwoPart(tag_name, ":");
            if (parts[0] == "pii")
            {
                FindTagResult result = Program.Rfid.FindTagByPII(
                    reader_name,
                    parts[1]);
                if (result.Value != 1)
                    return new NormalResult
                    {
                        Value = result.Value,
                        ErrorInfo = result.ErrorInfo,
                        ErrorCode = result.ErrorCode
                    };
                uid = result.UID;
                reader_name = result.ReaderName;    // 假如最初 reader_name 为 '*'，此处可以改为具体的读卡器名字，会加快后面设置的速度
            }
            else if (parts[0] == "uid" || string.IsNullOrEmpty(parts[0]))
                uid = parts[1];
            else
                return new NormalResult
                {
                    Value = -1,
                    ErrorInfo = $"未知的 tag_name 前缀 '{parts[0]}'",
                    ErrorCode = "unknownPrefix"
                };

            {
                // return result.Value
                //      -1  出错
                //      0   成功
                NormalResult result = Program.Rfid.SetEAS(
reader_name,
uid,
enable);
                if (result.Value == -1)
                    return result;
                return new NormalResult { Value = 1 };
            }
        }


        #region Tag List

        // 当前在读卡器探测范围内的标签
        List<OneTag> _tagList = new List<OneTag>();
        internal ReaderWriterLockSlim _lockTagList = new ReaderWriterLockSlim();

        bool AddToTagList(string reader_name,
            string uid,
            byte dsfid)
        {
            OneTag tag = FindTag(uid);
            if (tag != null)
                return false;
            _lockTagList.EnterWriteLock();
            try
            {
                tag = new OneTag
                {
                    ReaderName = reader_name,
                    UID = uid,
                    LastActive = DateTime.Now,
                    DSFID = dsfid
                };
                tag.LastActive = DateTime.Now;
                _tagList.Add(tag);
            }
            finally
            {
                _lockTagList.ExitWriteLock();
            }

            // 触发通知动作
            // TODO: 通知以后，最好把标签内容信息给存储起来，这样 Inventory 的时候可以直接使用
            if (_sendKeyEnabled.Value == true)
                Notify(tag.ReaderName, tag.UID);
            return true;
        }

        OneTag FindTag(string uid)
        {
            _lockTagList.EnterReadLock();
            try
            {
                foreach (OneTag tag in _tagList)
                {
                    if (tag.UID == uid)
                    {
                        tag.LastActive = DateTime.Now;
                        return tag;
                    }
                }
                return null;
            }
            finally
            {
                _lockTagList.ExitReadLock();
            }
        }

        void ClearIdleTag(TimeSpan delta)
        {
            List<OneTag> delete_tags = new List<OneTag>();
            _lockTagList.EnterReadLock();
            try
            {
                DateTime now = DateTime.Now;
                foreach (OneTag tag in _tagList)
                {
                    if (now - tag.LastActive >= delta)
                        delete_tags.Add(tag);
                }
            }
            finally
            {
                _lockTagList.ExitReadLock();
            }

            if (delete_tags.Count > 0)
            {
                _lockTagList.EnterWriteLock();
                try
                {
                    foreach (OneTag tag in delete_tags)
                    {
                        _tagList.Remove(tag);
                    }
                }
                finally
                {
                    _lockTagList.ExitWriteLock();
                }
            }
        }

        void Notify(string reader_name, string uid)
        {
            Task.Run(() =>
            {
                bool succeed = false;
                for (int i = 0; i < 10; i++)
                {
                    succeed = NotifyTag(reader_name, uid);
                    if (succeed == true)
                        break;
                    Thread.Sleep(100);
                }
                if (succeed == false)
                    Program.MainForm.OutputHistory($"读卡器{reader_name}读取标签{uid}详细信息时出错", 1);
            });
        }

        #endregion

        private AtomicBoolean _sendKeyEnabled = new AtomicBoolean(false);

        public NormalResult EnableSendKey(bool enable)
        {
            if (enable == true)
                this._sendKeyEnabled.FalseToTrue();
            else
                this._sendKeyEnabled.TrueToFalse();

            if (enable)
                Program.MainForm.OutputHistory("SendKey 打开", 0);
            else
                Program.MainForm.OutputHistory("SendKey 关闭", 0);
            return new NormalResult();
        }

        // 开始或者结束捕获标签
        public NormalResult BeginCapture(bool begin)
        {
            StartInventory(begin);
            return new NormalResult();
        }

        // 启动或者停止自动盘点
        void StartInventory(bool start)
        {
            // TODO: 是否要加锁，让本函数不能并行执行？
            if (start)
            {
                _cancelInventory?.Cancel();
                while (_cancelInventory != null)
                {
                    Task.Delay(500).Wait();
                }

                var task = DoInventory();
                // Task.Run(() => { DoInventory(); });
            }
            else
            {
                _cancelInventory?.Cancel();
                while (_cancelInventory != null)
                {
                    Task.Delay(500).Wait();
                }
            }
        }

        CancellationTokenSource _cancelInventory = null;

        async Task DoInventory()
        {
            Program.MainForm.OutputHistory("开始捕获", 0);

            if (Program.Rfid.Readers.Count == 0)
                Program.MainForm.OutputHistory("当前没有可用的读卡器", 2);

            _cancelInventory = new CancellationTokenSource();
            bool bFirst = true;
            try
            {
                while (_cancelInventory.IsCancellationRequested == false)
                {
                    await Task.Delay(200, _cancelInventory.Token).ConfigureAwait(false);
                    ClearIdleTag(TimeSpan.FromSeconds(1));  // 1 秒的放误触发时间

                    //if (_captureEnabled.Value == false)
                    //    continue;

                    foreach (Reader reader in Program.Rfid.Readers)
                    {
                        if (reader == null)
                            continue;

                        InventoryResult inventory_result = Program.Rfid.Inventory(
                            reader.Name, bFirst ? "" : "only_new");
                        // bFirst = false;
                        if (inventory_result.Value == -1)
                        {
                            // ioError 要主动卸载有问题的 reader?
                            // 如何报错？写入操作历史？
                            Program.MainForm.OutputHistory($"读卡器{reader.Name}点选标签时出错:{inventory_result.ToString()}\r\n已停止捕获过程", 2);
                            // Task.Delay(500, _cancelInventory.Token);
                            return;
                        }

                        foreach (InventoryInfo info in inventory_result.Results)
                        {
                            AddToTagList(reader.Name, info.UID, info.DsfID);
                        }
                    }
                }
            }
            catch (TaskCanceledException)
            {

            }
            finally
            {
                _cancelInventory = null;
                Program.MainForm.OutputHistory("结束捕获", 0);
            }
        }

        bool NotifyTag(string reader_name, string uid)
        {
            if (_sendKeyEnabled.Value == false)
                return false;

            InventoryInfo info = new InventoryInfo { UID = uid };
            GetTagInfoResult result0 = Program.Rfid.GetTagInfo(reader_name, info);
            if (result0.Value == -1)
            {
                // TODO: 如何报错？写入操作历史?
                // Program.MainForm.OutputText($"读取标签{info.UID}信息时出错:{result0.ToString()}", 2);
                return false;
            }

            LogicChip chip = LogicChip.From(result0.TagInfo.Bytes,
                (int)result0.TagInfo.BlockSize,
                "" // result0.TagInfo.LockStatus
                );
            Element pii = chip.FindElement(ElementOID.PII);
            Element typeOfUsage = chip.FindElement(ElementOID.TypeOfUsage);

            StringBuilder text = new StringBuilder();
            if (pii == null)
                text.Append($"uid:{info.UID}");
            else
                text.Append($"pii:{pii.Text}");
            if (typeOfUsage != null)
                text.Append($",tou:{typeOfUsage.Text}");

            Program.MainForm.Invoke((Action)(() =>
            {
                // 发送 UID
                SendKeys.SendWait($"{text}\r");
            }));

            return true;
        }
    }
}
