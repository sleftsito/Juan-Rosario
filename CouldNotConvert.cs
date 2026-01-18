public class CouldNotConvert : Exception
{
        public CouldNotConvert() : base() {}
        public CouldNotConvert(string mensaje) : base(mensaje) {}
        public CouldNotConvert(string mensaje, Exception interna) : base(mensaje, interna) {}
}