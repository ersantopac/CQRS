namespace Core.Security.EmailAuthenticatorHelper;

public interface IEmailAuthenticatorHelper
{
    public Task<string> CreateEmailActivationKey();
    public Task<string> CreateEmailActivationCode();
}