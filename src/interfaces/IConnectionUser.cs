public interface IConnectionUser
{
    IConnectionPassword WithUserName(string userName);

    IConnectionPassword WithDefaultUserName();
}