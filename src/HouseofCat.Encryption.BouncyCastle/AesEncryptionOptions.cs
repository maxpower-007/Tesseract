﻿namespace HouseofCat.Encryption.BouncyCastle
{
    public class AesEncryptionOptions
    {
        public int MacBitSize { get; set; } = 128;
        public int NonceSize { get; set; } = 12;
    }
}
