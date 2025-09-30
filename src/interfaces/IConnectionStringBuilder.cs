public interface IConnectionStringBuilder
{
    IConnectionUser WithDomainName(string domainName);

    IConnectionUser WithDefaultDomainName();
}   