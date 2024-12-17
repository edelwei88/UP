using ExecLib;

namespace UnitTests
{
    public class Tests
    {
        [Test]
        public void GenerateCaptchaString_Length()
        {
            const int length = 4;

            int expected = 4;
            int result = Exec.GenerateCaptchaString(length).Length;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GenerateCaptchaString_OnlyLatinNumbers()
        {
            const int captchaLength = 10;
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            string[] captchas = new string[100];
            for (int i = 0; i < captchas.Length; i++)
                captchas[i] = Exec.GenerateCaptchaString(captchaLength);

            Assert.That(captchas.All(captcha => captcha.All(ch => chars.Contains(ch))), Is.EqualTo(true));
        }

        [Test]
        public void GetAvgTime_Rightousness()
        {
            long expected = 2;

            DBController.Models.Request[] reqs = {
                new(1, new DateTime(2024, 12, 15), "", new DateTime(2024, 12, 17), new KeyValuePair<int, string>(1, ""), new KeyValuePair<int, string>(1, ""), new KeyValuePair<int, string>(1, ""), null, new KeyValuePair<int, string>(1, "")),
                new(1, new DateTime(2024, 12, 15), "", new DateTime(2024, 12, 17), new KeyValuePair<int, string>(1, ""), new KeyValuePair<int, string>(1, ""), new KeyValuePair<int, string>(1, ""), null, new KeyValuePair<int, string>(1, "")),
                new(1, new DateTime(2024, 12, 15), "", new DateTime(2024, 12, 17), new KeyValuePair<int, string>(1, ""), new KeyValuePair<int, string>(1, ""), new KeyValuePair<int, string>(1, ""), null, new KeyValuePair<int, string>(1, "")),
                new(1, new DateTime(2024, 12, 15), "", new DateTime(2024, 12, 17), new KeyValuePair<int, string>(1, ""), new KeyValuePair<int, string>(1, ""), new KeyValuePair<int, string>(1, ""), null, new KeyValuePair<int, string>(1, "")),
                new(1, new DateTime(2024, 12, 15), "", new DateTime(2024, 12, 17), new KeyValuePair<int, string>(1, ""), new KeyValuePair<int, string>(1, ""), new KeyValuePair<int, string>(1, ""), null, new KeyValuePair<int, string>(1, "")),
            };
            long result = Exec.GetAvgTime(reqs.ToList());

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetAvgTime_Nulls()
        {
            long expected = 0;

            DBController.Models.Request[] reqs = new DBController.Models.Request[10];
            long result = Exec.GetAvgTime(reqs.ToList());

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetAvgTime_Count0()
        {
            long expected = 0;

            List<DBController.Models.Request> reqs = new();
            long result = Exec.GetAvgTime(reqs.ToList());

            Assert.That(result, Is.EqualTo(expected));
        }

    }
}