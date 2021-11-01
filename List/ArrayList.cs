using System;
using DevEducation;

namespace List
{
    public class ArrayList
    {
        public int Lenght { get; private set; }

        private const int _minArrayLenght = 10;

        private int[] _array;

        public ArrayList()
        {
            Lenght = 0;
            _array = new int[_minArrayLenght];
        }


        private void UpArraySize()
        {
            int[] tmpArray = new int[(int)(Lenght * 1.5)];
            for (int i = 0; i < Lenght; i++)
            {
                tmpArray[i] = _array[i];
            }
            _array = tmpArray;
        }

        public void AddFront (int value)
        {
            if (Lenght == _array.Length)
            {
                UpArraySize();
            }

            _array[Lenght] = value;
            Lenght++;
        }


        public void WriteToConsole()
        {
            for (int i = 0; i < Lenght; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }
        
        public void ListAddBack(int value)
        {
            int cnt;
            int tmp;

            cnt = Lenght;
            if (Lenght == _array.Length)
                UpArraySize();
            while (cnt > 0)
            {
                tmp = _array[cnt];
                _array[cnt] = _array[cnt - 1];
                _array[cnt - 1] = tmp;
                cnt--;
            }
            _array[0] = value;
            Lenght++;
        }
        public void AddByIndex(int index, int value)
        {
            int cnt;
            int tmp;

            cnt = Lenght;
            if (Lenght == _array.Length)
                UpArraySize();
            while (cnt > index)
            {
                tmp = _array[cnt];
                _array[cnt] = _array[cnt - 1];
                _array[cnt - 1] = tmp;
                cnt--;
            }
            _array[index] = value;
            Lenght++;
        }
        public void DeleteAtEnd()
        {
            _array[Lenght - 1] = 0;
            Lenght--;
        }
        public void DeleteAtHead()
        {
            int cnt;
            int tmp;

            cnt = 0;
            while(cnt < Lenght)
            {
                tmp = _array[cnt];
                _array[cnt] = _array[cnt + 1];
                _array[cnt + 1] = tmp;
                cnt++;
            }
            _array[Lenght - 1] = 0;
            Lenght--;
        }
        public void DeleteByIndex(int index)
        {
            int cnt;
            int tmp;

            cnt = index;
            while (cnt < Lenght)
            {
                tmp = _array[cnt];
                _array[cnt] = _array[cnt + 1];
                _array[cnt + 1] = tmp;
                cnt++;
            }
            _array[Lenght - 1] = 0;
            Lenght--;
        }
        public void DeleteSomeIndexesFromEnd(int amountIndexes)
        {
            int cnt;

            cnt =Lenght - amountIndexes;

            while(cnt < Lenght)
                _array[cnt++] = 0;
            Lenght -= amountIndexes;
        }
        public void DeleteSomeIndexesFromStart(int amountIndexes)
        {
            int cnt;
            int start;

            cnt = amountIndexes;
            start = 0;
            while (cnt < Lenght)
            {
                _array[start] = _array[cnt];
                start++;
                cnt++;
            }
            Lenght -= amountIndexes;
        }
        public void DeleteSomeIndexesFromNeededIndex(int start, int amountIndexes)
        {
            int startCopyFrom; ;
            int tmp;

            tmp = 0;
            startCopyFrom = start + amountIndexes;

            while(startCopyFrom < Lenght)
            {
                _array[start] = _array[startCopyFrom];
                start++;
                startCopyFrom++;
                tmp++;
            }
            Lenght -= amountIndexes;
        }
        public int GetLenght()
        {
            return Lenght;
        }

        public int GetContentByIndex(int index)
        {
            if (index > Lenght)
                throw new ArgumentException("Too much index, take some less than " + Lenght);
            return _array[index];
        }
        public int FindFirstIndexByThisContent(int content)
        {
            int index;

            index = -1;
            while (++index < Lenght)
            {
                if (_array[index] == content)
                    return index;
            }
            return -1;
        }
        public void ChangeContentByIndex(int content, int index)
        {
            _array[index] = content;
        }
        
        public void ReverseArray()
        {
            int cnt;
            int tmp;

            cnt = 0;
            while (cnt < (Lenght / 2))
            {
                tmp = _array[cnt];
                _array[cnt] = _array[Lenght - cnt - 1];
                _array[Lenght - cnt - 1] = tmp;
                cnt++;
            }
        }

        public int FindMaxContent()
        {
            int content;

            content = DevEducation.Arrays.PartOne.FindMaxNumb(_array);
            return content;
        }

        public int FindMinContent()
        {
            int content;

            content = DevEducation.Arrays.PartOne.FindMinNumb(_array);
            return content;
        }

        public int FindIndexOfMaxContent()
        {
            int index;

            index = DevEducation.Arrays.PartOne.FindIndexMaxNumb(_array);
            return index;
        }

        public int FindIndexOfMinContent()
        {
            int index;

            index = DevEducation.Arrays.PartOne.FindIndexMinNumb(_array);
            return index;
        }

        public void SortByAscending()
        {
            int cnt;
            int[] arr = new int[Lenght];
            cnt = -1;
            while (++cnt < Lenght)
                arr[cnt] = _array[cnt];
            arr = DevEducation.Arrays.SomeSorts.SelectSort(arr);
            cnt = -1;
            while (++cnt < Lenght)
                _array[cnt] = arr[cnt];
        }

        public void SortByDecrease()
        {
            int cnt;
            int[] arr = new int[Lenght];
            cnt = -1;
            while (++cnt < Lenght)
            {
                arr[cnt] = _array[cnt];
            }
            arr = DevEducation.Arrays.SomeSorts.BubbleSort(arr);
            cnt = -1;
            while (++cnt < Lenght)
                _array[cnt] = arr[cnt];
        }

        public int DeleteFirstElemByContent(int content)
        {
            int cnt;

            cnt = 0;
            while (cnt < Lenght)
            {
                if (content == _array[cnt])
                {
                    DeleteByIndex(cnt);
                    return  cnt;
                }
                cnt++;
            }
            return -1;
        }
        public int DeleteAllElemsWithGivenContent(int content)
        {
            int cnt;
            int amount;

            cnt = 0;
            amount = 0;
            while (cnt < Lenght)
            {
                if (content == _array[cnt])
                {
                    DeleteByIndex(cnt);
                    amount++;
                }
                cnt++;
            }
            return amount;
        }
    }
}
