namespace muchik.market.infrastructure.crosscutting.Jwt
{
    public interface IJwtManager
    {
        string GenerateToken(string userId, string username);
    }
}
