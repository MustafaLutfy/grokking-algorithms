using System;



namespace HashMap {

    class Roads {
        public string locOne, locTwo;
        public Roads(string locOne, string locTwo) {
            this.locOne = locOne;
            this.locTwo = locTwo;
        }
    }

    class HashLocation{
        static int size = 26;
        Roads[] arrRoads = new Roads[size];

        public void Set(string location, string locOne, string locTwo) {
            Roads tempObj = new Roads(locOne, locTwo);
            int index = HashFunc(location);
            arrRoads[index] = tempObj;
        }

        int HashFunc(string location) {
            int value = SumLetters(location.ToUpper());
            return value % size;
        }

        int SumLetters(string location) {
            int summation = 0;
            for (int i = 0; i < location.Length; i++) {
                summation += Convert.ToInt32(location[i]);
            }
            return summation;
        }

        public Roads Get(string location) {
            int index = HashFunc(location.ToUpper());
            return arrRoads[index];
        }

    }

    // class Program {
    //     public static void Main(string[] args) {
    //         HashLocation HM = new HashLocation();
    //         HM.Set("Iraq", 35.525, 24.242);
    //         Console.WriteLine(HM.Get("Iraq").lang);
    //     }
    // }
}