﻿//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由Codesmith工具生成。
// 此文件的更改可能会导致不正确的行为，如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Collection;
using ZyGames.Framework.Game.Service;
using ZyGames.Framework.Model;
using ZyGames.Framework.Game.Context;

namespace ZyGames.Doudizhu.Model
{
    /// <summary>
    /// 玩家信息[:BaseUser]
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
    [EntityTable(DbConfig.Data, "GameUser", DbConfig.PeriodTime, DbConfig.PersonalName)]
    public class GameUser : BaseUser
    {

        /// <summary>
        /// </summary>
        public GameUser()
            : base(AccessLevel.ReadWrite)
        {
            Property = new UserProperty();
        }        
        /// <summary>
        /// </summary>
        public GameUser(int userId)
            : this()
        {
            _userId = userId;
        }

        #region 自动生成属性
        private int _userId;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("UserId", IsKey = true)]
        public int UserId
        {
            get
            {
                return _userId;
            } 
			private set
			{
				_userId = value;
			}
        }
        private string _pid;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("Pid")]
        public string Pid
        {
            get
            {
                return _pid;
            } 
            set
            {
                SetChange("Pid", value);
            }
        }
        private string _nickName;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("NickName")]
        public string NickName
        {
            get
            {
                return _nickName;
            } 
            set
            {
                SetChange("NickName", value);
            }
        }
        private string _headIcon;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("HeadIcon")]
        public string HeadIcon
        {
            get
            {
                return _headIcon;
            } 
            set
            {
                SetChange("HeadIcon", value);
            }
        }
        private bool _sex;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("Sex")]
        public bool Sex
        {
            get
            {
                return _sex;
            } 
            set
            {
                SetChange("Sex", value);
            }
        }
        private string _retailId;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("RetailId")]
        public string RetailId
        {
            get
            {
                return _retailId;
            } 
            set
            {
                SetChange("RetailId", value);
            }
        }
        private int _payGold;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("PayGold")]
        public int PayGold
        {
            get
            {
                return _payGold;
            } 
            set
            {
                SetChange("PayGold", value);
            }
        }
        private int _giftGold;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("GiftGold")]
        public int GiftGold
        {
            get
            {
                return _giftGold;
            } 
            set
            {
                SetChange("GiftGold", value);
            }
        }
        private int _extGold;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("ExtGold")]
        public int ExtGold
        {
            get
            {
                return _extGold;
            } 
            set
            {
                SetChange("ExtGold", value);
            }
        }
        private int _useGold;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("UseGold")]
        public int UseGold
        {
            get
            {
                return _useGold;
            } 
            set
            {
                SetChange("UseGold", value);
            }
        }
        private int _gameCoin;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(11)]
        [EntityField("GameCoin")]
        public int GameCoin
        {
            get
            {
                return _gameCoin;
            } 
            set
            {
                SetChange("GameCoin", value);
            }
        }
        private short _userLv;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(12)]
        [EntityField("UserLv")]
        public short UserLv
        {
            get
            {
                return _userLv;
            } 
            set
            {
                SetChange("UserLv", value);
            }
        }
        private int _vipLv;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(13)]
        [EntityField("VipLv")]
        public int VipLv
        {
            get
            {
                return _vipLv;
            } 
            set
            {
                SetChange("VipLv", value);
            }
        }
        private int _rankId;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(14)]
        [EntityField("RankId")]
        public int RankId
        {
            get
            {
                return _rankId;
            } 
            set
            {
                SetChange("RankId", value);
            }
        }
        private UserStatus _userStatus;
        /// <summary>
        /// 玩家状态[Enum<UserStatus>]
        /// </summary>        
        [ProtoMember(15)]
        [EntityField("UserStatus")]
        public UserStatus UserStatus
        {
            get
            {
                return _userStatus;
            } 
            set
            {
                SetChange("UserStatus", value);
            }
        }
        private bool _msgState;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(16)]
        [EntityField("MsgState")]
        public bool MsgState
        {
            get
            {
                return _msgState;
            } 
            set
            {
                SetChange("MsgState", value);
            }
        }
        private MobileType _mobileType;
        /// <summary>
        /// 玩家状态[Enum<MobileType>]
        /// </summary>        
        [ProtoMember(17)]
        [EntityField("MobileType")]
        public MobileType MobileType
        {
            get
            {
                return _mobileType;
            } 
            set
            {
                SetChange("MobileType", value);
            }
        }
        private short _screenX;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(18)]
        [EntityField("ScreenX")]
        public short ScreenX
        {
            get
            {
                return _screenX;
            } 
            set
            {
                SetChange("ScreenX", value);
            }
        }
        private short _screenY;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(19)]
        [EntityField("ScreenY")]
        public short ScreenY
        {
            get
            {
                return _screenY;
            } 
            set
            {
                SetChange("ScreenY", value);
            }
        }
        private short _clientAppVersion;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(20)]
        [EntityField("ClientAppVersion")]
        public short ClientAppVersion
        {
            get
            {
                return _clientAppVersion;
            } 
            set
            {
                SetChange("ClientAppVersion", value);
            }
        }
        private DateTime _createDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(21)]
        [EntityField("CreateDate")]
        public DateTime CreateDate
        {
            get
            {
                return _createDate;
            } 
            set
            {
                SetChange("CreateDate", value);
            }
        }
        private DateTime _loginDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(22)]
        [EntityField("LoginDate")]
        public DateTime LoginDate
        {
            get
            {
                return _loginDate;
            } 
            set
            {
                SetChange("LoginDate", value);
            }
        }
        private DateTime _lastLoginDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(23)]
        [EntityField("LastLoginDate")]
        public DateTime LastLoginDate
        {
            get
            {
                return _lastLoginDate;
            } 
            set
            {
                SetChange("LastLoginDate", value);
            }
        }
        private int _winNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(24)]
        [EntityField("WinNum")]
        public int WinNum
        {
            get
            {
                return _winNum;
            } 
            set
            {
                SetChange("WinNum", value);
            }
        }
        private int _failNum;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(25)]
        [EntityField("FailNum")]
        public int FailNum
        {
            get
            {
                return _failNum;
            } 
            set
            {
                SetChange("FailNum", value);
            }
        }
        private int _scoreNum;
        /// <summary>
        /// 积分
        /// </summary>        
        [ProtoMember(26)]
        [EntityField("ScoreNum")]
        public int ScoreNum
        {
            get
            {
                return _scoreNum;
            } 
            set
            {
                SetChange("ScoreNum", value);
            }
        }
        private int _titleId;
        /// <summary>
        /// 称号ID
        /// </summary>        
        [ProtoMember(27)]
        [EntityField("TitleId")]
        public int TitleId
        {
            get
            {
                return _titleId;
            } 
            set
            {
                SetChange("TitleId", value);
            }
        }
        private string _realName;
        /// <summary>
        /// 真实姓名
        /// </summary>        
        [ProtoMember(28)]
        [EntityField("RealName")]
        public string RealName
        {
            get
            {
                return _realName;
            } 
            set
            {
                SetChange("RealName", value);
            }
        }
        private DateTime _birthday;
        /// <summary>
        /// 生日
        /// </summary>        
        [ProtoMember(29)]
        [EntityField("Birthday")]
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            } 
            set
            {
                SetChange("Birthday", value);
            }
        }
        private string _hobby;
        /// <summary>
        /// 爱好
        /// </summary>        
        [ProtoMember(30)]
        [EntityField("Hobby")]
        public string Hobby
        {
            get
            {
                return _hobby;
            } 
            set
            {
                SetChange("Hobby", value);
            }
        }
        private string _profession;
        /// <summary>
        /// 职业
        /// </summary>        
        [ProtoMember(31)]
        [EntityField("Profession")]
        public string Profession
        {
            get
            {
                return _profession;
            } 
            set
            {
                SetChange("Profession", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "UserId": return _userId;
                    case "Pid": return _pid;
                    case "NickName": return _nickName;
                    case "HeadIcon": return _headIcon;
                    case "Sex": return _sex;
                    case "RetailId": return _retailId;
                    case "PayGold": return _payGold;
                    case "GiftGold": return _giftGold;
                    case "ExtGold": return _extGold;
                    case "UseGold": return _useGold;
                    case "GameCoin": return _gameCoin;
                    case "UserLv": return _userLv;
                    case "VipLv": return _vipLv;
                    case "RankId": return _rankId;
                    case "UserStatus": return _userStatus;
                    case "MsgState": return _msgState;
                    case "MobileType": return _mobileType;
                    case "ScreenX": return _screenX;
                    case "ScreenY": return _screenY;
                    case "ClientAppVersion": return _clientAppVersion;
                    case "CreateDate": return _createDate;
                    case "LoginDate": return _loginDate;
                    case "LastLoginDate": return _lastLoginDate;
                    case "WinNum": return _winNum;
                    case "FailNum": return _failNum;
                    case "ScoreNum": return _scoreNum;
                    case "TitleId": return _titleId;
                    case "RealName": return _realName;
                    case "Birthday": return _birthday;
                    case "Hobby": return _hobby;
                    case "Profession": return _profession;
					default: throw new ArgumentException(string.Format("GameUser index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "UserId": 
                        _userId = value.ToInt();
                        break; 
                    case "Pid": 
                        _pid = value.ToNotNullString();
                        break; 
                    case "NickName": 
                        _nickName = value.ToNotNullString();
                        break; 
                    case "HeadIcon": 
                        _headIcon = value.ToNotNullString();
                        break; 
                    case "Sex": 
                        _sex = value.ToBool();
                        break; 
                    case "RetailId": 
                        _retailId = value.ToNotNullString();
                        break; 
                    case "PayGold": 
                        _payGold = value.ToInt();
                        break; 
                    case "GiftGold": 
                        _giftGold = value.ToInt();
                        break; 
                    case "ExtGold": 
                        _extGold = value.ToInt();
                        break; 
                    case "UseGold": 
                        _useGold = value.ToInt();
                        break; 
                    case "GameCoin": 
                        _gameCoin = value.ToInt();
                        break; 
                    case "UserLv": 
                        _userLv = value.ToShort();
                        break; 
                    case "VipLv": 
                        _vipLv = value.ToInt();
                        break; 
                    case "RankId": 
                        _rankId = value.ToInt();
                        break; 
                    case "UserStatus": 
                        _userStatus = value.ToEnum<UserStatus>();
                        break; 
                    case "MsgState": 
                        _msgState = value.ToBool();
                        break; 
                    case "MobileType": 
                        _mobileType = value.ToEnum<MobileType>();
                        break; 
                    case "ScreenX": 
                        _screenX = value.ToShort();
                        break; 
                    case "ScreenY": 
                        _screenY = value.ToShort();
                        break; 
                    case "ClientAppVersion": 
                        _clientAppVersion = value.ToShort();
                        break; 
                    case "CreateDate": 
                        _createDate = value.ToDateTime();
                        break; 
                    case "LoginDate": 
                        _loginDate = value.ToDateTime();
                        break; 
                    case "LastLoginDate": 
                        _lastLoginDate = value.ToDateTime();
                        break; 
                    case "WinNum": 
                        _winNum = value.ToInt();
                        break; 
                    case "FailNum": 
                        _failNum = value.ToInt();
                        break; 
                    case "ScoreNum": 
                        _scoreNum = value.ToInt();
                        break; 
                    case "TitleId": 
                        _titleId = value.ToInt();
                        break; 
                    case "RealName": 
                        _realName = value.ToNotNullString();
                        break; 
                    case "Birthday": 
                        _birthday = value.ToDateTime();
                        break; 
                    case "Hobby": 
                        _hobby = value.ToNotNullString();
                        break; 
                    case "Profession": 
                        _profession = value.ToNotNullString();
                        break; 
					default: throw new ArgumentException(string.Format("GameUser index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
        
        protected override int GetIdentityId()
        {
            //设置玩家的UserID
            //若要做为全局使用设置类绑定的自定义属性[EntityTable(CacheType.Entity, DbConfig.Config, @TableName, @PeriodTime)]
            return UserId;
        }        
        
        public override string GetSessionId()
        {
            return SessionID;
        }

        public override int GetUserId()
        {
            return UserId;
        }

        public override string GetNickName()
        {
            return NickName;
        }

        public override string GetPassportId()
        {
            return Pid;
        }

        public override string GetRetailId()
        {
            return RetailId;
        }

        public override bool IsFengJinStatus
        {
            get { return UserStatus == UserStatus.FengJin; }
        }

        /// <summary>
        /// 玩家会话ID
        /// </summary>
        [ProtoMember(100)]
        public string SessionID { get; set; }

        /// <summary>
        /// 玩家请求时间,排除常刷新接口
        /// </summary>
        [ProtoMember(101)]
        public override DateTime OnlineDate { get; set; }

        /// <summary>
        /// 玩家属性
        /// </summary>
        [ProtoMember(102)]
        public UserProperty Property { get; set; }

	}
}