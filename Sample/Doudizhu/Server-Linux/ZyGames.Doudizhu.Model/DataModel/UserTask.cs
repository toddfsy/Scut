﻿//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由Codesmith工具生成。
// 此文件的更改可能会导致不正确的行为，如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using ProtoBuf;
using ZyGames.Framework.Cache.Generic;
using ZyGames.Framework.Common;
using ZyGames.Framework.Collection;
using ZyGames.Framework.Model;


namespace ZyGames.Doudizhu.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
    [EntityTable(DbConfig.Data, "UserTask", DbConfig.PeriodTime, DbConfig.PersonalName)]
    public class UserTask : BaseEntity
    {

        /// <summary>
        /// </summary>
        public UserTask()
            : base(AccessLevel.ReadWrite)
        {
            TaskPackage = new CacheList<UserTaskInfo>();
        }
        /// <summary>
        /// </summary>
        public UserTask(int userID)
            : this()
        {
            _userID = userID;
        }

        #region 自动生成属性
        private int _userID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("UserID", IsKey = true)]
        public int UserID
        {
            get
            {
                return _userID;
            }

        }
        private CacheList<UserTaskInfo> _taskPackage;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("TaskPackage", IsJsonSerialize = true, DbType = ColumnDbType.Text)]
        public CacheList<UserTaskInfo> TaskPackage
        {
            get
            {
                return _taskPackage;
            }
            set
            {
                SetChange("TaskPackage", value);
            }
        }

        protected override object this[string index]
        {
            get
            {
                #region
                switch (index)
                {
                    case "UserID": return _userID;
                    case "TaskPackage": return _taskPackage;
                    default: throw new ArgumentException(string.Format("UserTask index[{0}] isn't exist.", index));
                }
                #endregion
            }
            set
            {
                #region
                switch (index)
                {
                    case "UserID":
                        _userID = value.ToInt();
                        break;
                    case "TaskPackage":
                        _taskPackage = ConvertCustomField<CacheList<UserTaskInfo>>(value, index);
                        break;
                    default: throw new ArgumentException(string.Format("UserTask index[{0}] isn't exist.", index));
                }
                #endregion
            }
        }

        #endregion

        protected override int GetIdentityId()
        {
            //设置玩家的UserID
            //若要做为全局使用设置类绑定的自定义属性[EntityTable(CacheType.Entity, DbConfig.Config, @TableName, @PeriodTime)]
            return UserID;
        }

    }
}