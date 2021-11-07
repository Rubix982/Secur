using System;
using System.Diagnostics;
using Yort.Otp;

namespace Shared
{
    public class Totp
    {
        public const int Digits = 8; // digits of code
        private const int Period = 10; // interval for new TOTP in seconds
        private const int Tolerance = 1; // how many cycles either back or ahead to tolerate
        private readonly byte[] _secret;
        private readonly TimeBasedPasswordGenerator _totp;

        public Totp(byte[] secret)
        {
            this._totp = new TimeBasedPasswordGenerator(true, secret)
            {
                HashAlgorithm = null,
                PasswordLength = 0,
                TimeInterval = default,
                Timestamp = null
            };
            this._totp.TimeInterval = TimeSpan.FromSeconds(Period);
            this._totp.PasswordLength = Digits;
            this._secret = secret;
        }

        public string GetCode()
        {
            return _totp.GeneratedPassword;
        }

        public bool ConfirmCode(string code)
        {
            var time = DateTime.UtcNow;
            Debug.WriteLine(time);
            if (this._totp.GeneratedPassword.Equals(code))
            {
                return true;
            }
            for (var iterator = 0; iterator < Tolerance; iterator++)
            {
                var tmpTotp = new TimeBasedPasswordGenerator(true, this._secret);
                tmpTotp.TimeInterval = TimeSpan.FromSeconds(Period);
                tmpTotp.PasswordLength = Digits;
                time = time.AddSeconds(-Period);
                tmpTotp.Timestamp = time;
                var checkCode = tmpTotp.GeneratedPassword;
                if (checkCode.Equals(code))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
