﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    // Класс Одиночка предоставляет метод `GetInstance`, который ведёт себя как
    // альтернативный конструктор и позволяет клиентам получать один и тот же
    // экземпляр класса при каждом вызове.
    public class SimpleSoingleton
    {
        // Конструктор Одиночки всегда должен быть скрытым, чтобы предотвратить
        // создание объекта через оператор new.
        private SimpleSoingleton() { }

        // Объект одиночки храниться в статичном поле класса. Существует
        // несколько способов инициализировать это поле, и все они имеют разные
        // достоинства и недостатки. В этом примере мы рассмотрим простейший из
        // них, недостатком которого является полная неспособность правильно
        // работать в многопоточной среде.
        private static SimpleSoingleton _instance { get; set; }

        // Это статический метод, управляющий доступом к экземпляру одиночки.
        // При первом запуске, он создаёт экземпляр одиночки и помещает его в
        // статическое поле. При последующих запусках, он возвращает клиенту
        // объект, хранящийся в статическом поле.
        public static SimpleSoingleton GetInstance(string value)
        {
            if (_instance == null)
            {
                _instance = new SimpleSoingleton();
                _instance.Value = value;
                
            }
            return _instance;
        }

        // Наконец, любой одиночка должен содержать некоторую бизнес-логику,
        // которая может быть выполнена на его экземпляре.
        public static void BussinessLogic()
        {
            //
        }
        //Just for test
        public string Value { get; set; }
    }
}
