namespace xAuth.Interface
{
    public interface IAuth
    {
        ITokenRespons AuthentiacteUser(IUser user, string audiance, string domain);
        ITokenRespons AuthenticateTokenKey(IToken token, string audiance, string domain);
    }
}