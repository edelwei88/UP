using DBController.Models;
using System.Text;

namespace ExecLib
{
    public static class Exec
    {
        public static long GetAvgTime(List<Request> requests)
        {
            if (requests == null || requests.Count == 0 || requests.Any(req => req == null))
                return 0;

            long avgTime = 0;
            foreach (var req in requests.Where(req => req.completionDate.HasValue))
                avgTime += ((DateTimeOffset)req.completionDate.Value).ToUnixTimeSeconds() - ((DateTimeOffset)req.startDate).ToUnixTimeSeconds();

            return avgTime / 60 / 60 / 24 / requests.Where(req => req.completionDate.HasValue).Count();
        }

        public static string GenerateCaptchaString(int length)
        {
            var seed = DateTime.Now.Millisecond;
            var rand = new Random(seed);
            var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            var captcha = new StringBuilder();
            while (length-- > 0)
            {
                int index = rand.Next(62);
                captcha.Append(chars[index]);
            }

            return captcha.ToString();
        }
    }


}
