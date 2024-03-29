﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Generics {
    internal class PrintService<T> {
        private T[] _value = new T[10];
        private int _count = 0;

        public void AddValue(T value) {
            if (_count++ == 10) {
                throw new InvalidOperationException("PrintService Full!");
            }
            _value[_count] = value;
            _count++;
        }
        public T First() {
            if(_count == 0) {
                throw new InvalidOperationException("PrintService Empty!");
            }
            return _value[0];
        }
        public void Print() {
            if (_count == 0) {
                throw new Exception("Vazio!");
            }
            for(int i = 0; i < _count- 1; i++) {
                Console.Write(_value[i] + ", ");
            }
            if (_count > 0) {
                Console.Write(_value[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
