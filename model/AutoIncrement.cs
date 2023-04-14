using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVaccine.model.utils {
    public class AutoIncrement<T> {
        private static string countFile = "./" + typeof(T).Name + ".cache";
        private static int count = CacheCount();
        private static int CacheCount() {
            Debug.WriteLine(countFile);
            if(!File.Exists(countFile)) {
                using(StreamWriter sw = new StreamWriter(countFile)) {
                    sw.Write(1);
                }
                return 1;
            }
            using(StreamReader sr = new StreamReader(countFile)) {
                string? s = sr.ReadLine();
                if(s == null) {
                    using (StreamWriter sw = new StreamWriter(countFile)) {
                        sw.Write(1);
                    }
                    return 1;
                }
                int c = int.Parse(s);
                return c;
            }
        }

        public static int GetCount() {
            Debug.WriteLine(count);
            using (StreamWriter sw = new StreamWriter(countFile)) {
                sw.Write(count + 1);
            }
            return count++;
        }
    }
}
