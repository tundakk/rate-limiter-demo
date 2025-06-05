namespace RateLimitingMiddlewareDemo.Models
{
    public class RateLimitRule
    {
        public int Limit { get; set; }
        public TimeSpan Window { get; set; }
    }
}