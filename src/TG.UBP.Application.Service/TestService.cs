using OSharp.Core.Data;
using TG.UBP.Core.Entity.BaseManage.Identity;


namespace TG.UBP.Application.Service
{
    public class TestService : ITestContract
    {
        /// <summary>
        /// 获取或设置 用户仓储对象
        /// </summary>
        public IRepository<User, int> UserRepository { get; set; }

        #region Implementation of ITestContract

        public void Test()
        {
            int count = UserRepository.UpdateDirect(m => true, user => new User() { NickName = "柳柳英侠112" });

        }

        #endregion
    }
}
