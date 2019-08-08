using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    // Эта реализация Одиночки называется "блокировка с двойной проверкой"
    // (double check lock). Она безопасна в многопоточной среде, а также
    // позволяет отложенную инициализацию объекта Одиночки.
    public class ConcurenteSingleton
    {
        private ConcurenteSingleton() { }
        private static ConcurenteSingleton _instance { get; set; }

        // У нас теперь есть объект-блокировка для синхронизации потоков во
        // время первого доступа к Одиночке.
        private static object _locker = new object();
       

        public static ConcurenteSingleton GetInstance(string value)
        {
            // Это условие нужно для того, чтобы не стопорить потоки блокировкой
            // после того как объект-одиночка уже создан.
            if (_instance == null)
            {
                // Теперь представьте, что программа была только-только
                // запущена. Объекта-одиночки ещё никто не создавал, поэтому
                // несколько потоков вполне могли одновременно пройти через
                // предыдущее условие и достигнуть блокировки. Самый быстрый
                // поток поставит блокировку и двинется внутрь секции, пока
                // другие будут здесь его ожидать.
                lock (_locker)
                {
                    // Первый поток достигает этого условия и проходит внутрь,
                    // создавая объект-одиночку. Как только этот поток покинет
                    // секцию и освободит блокировку, следующий поток может
                    // снова установить блокировку и зайти внутрь. Однако теперь
                    // экземпляр одиночки уже будет создан и поток не сможет
                    // пройти через это условие, а значит новый объект не будет
                    // создан.
                    if (_instance == null)
                    {
                        _instance = new ConcurenteSingleton();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }



        public static string BuissnesLogic()
        {
            return _instance.Value;
        }
        public string Value { get; set; }
    }
}
