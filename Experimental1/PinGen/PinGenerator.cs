using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace PinGen
{
    public class PinGenerator
    {
        private readonly int _amount;
        private  List<PinEntity> _pins;
        private readonly Random _random = new Random();
        public PinGenerator(int amount)
        {
            _amount = amount;
        }
        public void Genearate()
        {
            for (int i = 0; i < _amount; i++)
            {
                _pins = new List<PinEntity>()
                {
                    new PinEntity() { SerialNumber = RandomSerialNumber() , Pin = GetRandomPin()}
                };

               foreach(PinEntity pin in _pins)
                {
                    Console.WriteLine($"Serial Number:{pin.SerialNumber} Pin:{pin.Pin}");
                }
              
            }
        }
        private string GetRandomPin()
        {
            using (var crypto = new RNGCryptoServiceProvider())
            {
                byte[] buffer = new byte[7];
                crypto.GetBytes(buffer);
                var num = BitConverter.ToUInt32(buffer, 0);
                var pin = num % 100000;
                return pin.ToString("D5");
            }
        }
        private string RandomSerialNumber()
        {
            using(var crypto = new RNGCryptoServiceProvider())
            {
                var serial = new byte[5];
                crypto.GetBytes(serial);
                return BitConverter.ToString(serial);//.Replace("-", " ");

            }
        }



    }
}
