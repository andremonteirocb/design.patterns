namespace Design.Patterns.Singleton
{
    public sealed class ConexaoSingleton
    {
        public static object SyncObj = new object();
        public static Conexao _instance;
        public static Conexao GetInstance()
        {
            if (_instance != null) return _instance;

            lock (SyncObj)
            {
                if (_instance == null)
                    _instance = new Conexao();
            }

            return _instance;
        }
    }
}