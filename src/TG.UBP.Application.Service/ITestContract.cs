using OSharp.Core.Dependency;


namespace TG.UBP.Application.Service
{
    public interface ITestContract : IScopeDependency
    {
        void Test();
    }
}
