namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] nums = { 2, 7, 11, 15, 9 };
            int[] result = TwoSumUsingHashTabke(nums, 9);
            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
            //-------------------------------------------------------------
            //2
            // int resultRev= ReverseAlgo(-2147483648);
            //Console.WriteLine(resultRev);
            //-------------------------------------------------------------
            //3)
            //int sum = RomanToInt("LVIII");
            //Console.WriteLine(sum);

            //4)
            //string[] data = new string[] {"ca", "a"};
            //string res=LongestCommonPrefix(data);
            //Console.WriteLine(res);

            //5)
            //Console.WriteLine(IsValid("{[}]"));

            //6)
            // int[] data = new int[] { 0, 0, 1, 1, 2, 2, 3, 3, 4,4 };
            //Console.WriteLine(RemoveDuplicates(data));
            //-----------------------------------------------------
            //7)
            //int[] data = new int[] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4 };
            //Console.WriteLine(RemoveElement(data,0));
            //-----------------------------------------------------
            //9)
            //Console.WriteLine(StrStr("aaaaa", "ll"));
            //---------------------------------------------------------
            //10)
            //int[] data = new int[] { 1, 3, 5, 6 };
            //Console.WriteLine(SearchInsert(data,3));
            //----------------------------------------------
            //11)
            //int[] data = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //Console.WriteLine(MaxSubArray(data));
            //----------------------------------------
            //12)
            //[0,8,6,5,6,8,3,5,7]
            //[6,7,8,0,8,5,8,9,7]
            //[2,4,3]
            //[5,6,4]
            //    ListNode node2 = new ListNode(2, null);
            //    ListNode node3 = new ListNode(4, null);
            //    ListNode node4 = new ListNode(3, null);
            //    node2.next = node3;
            //    node3.next = node4;
            //ListNode node11 = new ListNode(5, null);
            //ListNode node12= new ListNode(6, null);
            //ListNode node13 = new ListNode(4, null);
            //node11.next = node12;
            //node12.next = node13;
            //Console.WriteLine(AddTwoNumbers(node2, node11));
            //------------------------------------------------------
            //13)
            //Console.WriteLine(LengthOfLastWord("He "));

            //---------------------------------------------
            //14)
            //int[] digits = new int[] {6, 1, 4, 5, 3, 9, 0, 1, 9, 5, 1, 8, 6, 7, 0, 5, 5, 4, 3};
            //Console.WriteLine(PlusOne(digits));

            //15)
            //Console.WriteLine(AddBinary("0", "0"));

            //16)
            //Console.WriteLine(MySqrt(8));

            //17)
            Console.WriteLine(ClimbStairs(20));

        }
        //1
        public int[] TwoSum(int[] nums, int target)
        {
            int currentElement;

            for (var i = 0; i < nums.Length; i++)
            {
                currentElement = nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    if (currentElement + nums[j] == target && i != j)
                    {
                        return new int[] { i, j };
                    }


                }

            }
            return new int[] { 0, 0 };

        }
        public static int[] TwoSumUsingHashTabke(int[] nums, int target)
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();
            int complement;
            for (int i = 0; i < nums.Length; i++)
            {
                hash.Add(i, nums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];
                int reuslt = hash.FirstOrDefault(x => x.Value == complement).Key;
                if (hash.ContainsValue(complement) && i != reuslt)
                {
                    return new int[] { i, reuslt };
                }
            }

            return null;

        }
        //-----------------------------------------------------------------
        //2
        public static int Reverse(int x)
        {
            string number = x.ToString();
            double finalResult;
            string tempResult = "";
            bool checkIfNegative = false;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '-')
                {
                    tempResult += "-";
                    checkIfNegative = true;
                }
                else
                {
                    stack.Push(number[i]);
                }
            }


            int countOfStack = stack.Count;
            char currentStackData;
            for (int i = 0; i < countOfStack; i++)
            {
                currentStackData = stack.Pop();
                if ((i == 0 && currentStackData != 0) || i != 0)
                {
                    tempResult += currentStackData;
                }
            }
            finalResult = checkIfNegative ? double.Parse(tempResult) * -1 : double.Parse(tempResult);

            return finalResult > int.MaxValue ? 0 : Int32.Parse(tempResult);
        }
        public static long ReverseAlgo(long x)
        {
            long rev = 0;
            while (x != 0)
            {
                rev = rev * 10 + x % 10;
                x /= 10;
            }
            return rev;
        }
        public static string ReverseStr(string x)
        {
            string tempResult = "";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < x.Length; i++)
            {

                stack.Push(x[i]);

            }

            for (int i = 0; i < x.Length; i++)
            {
                tempResult += stack.Pop();

            }

            return tempResult;
        }
        //-------------------------------------------------------------------
        //3
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            else
            {
                int res = 0;
                int tempX = x;
                while (tempX != 0)
                {
                    res = res * 10 + tempX % 10;
                    tempX /= 10;
                }

                if (res == x) return true;
                return res == x ? true : false;
            }
        }
        //---------------------------------------------------------------------------
        //4
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanlanguage = new Dictionary<char, int>();
            romanlanguage.Add('I', 1);
            romanlanguage.Add('V', 5);
            romanlanguage.Add('X', 10);
            romanlanguage.Add('L', 50);
            romanlanguage.Add('C', 100);
            romanlanguage.Add('D', 500);
            romanlanguage.Add('M', 1000);
            int currentValue, nextValue, sum = 0;
            for (int i = 0; i < s.Length; i++)
            {

                if (i + 1 < s.Length)
                {
                    romanlanguage.TryGetValue(s[i], out currentValue);
                    romanlanguage.TryGetValue(s[i + 1], out nextValue);
                    if (currentValue >= nextValue)
                    {
                        sum += currentValue;
                    }
                    else
                    {
                        sum -= currentValue;
                    }
                }
                else
                {
                    romanlanguage.TryGetValue(s[i], out currentValue);
                    sum += currentValue;

                }



            }
            return sum;
            //I             1
            //V             5
            //X             10
            //L             50
            //C             100
            //D             500
            //M             1000
        }
        //---------------------------------------------------------------------------
        //4
        public static string LongestCommonPrefix2(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }

            int Index = -1;
            int minLength = int.MaxValue;
            Dictionary<string, int> splitMimWords = new Dictionary<string, int>();


            for (int i = 0; i < strs.Length; i++)
            {
                if (minLength > strs[i].Length)
                {
                    minLength = strs[i].Length;
                    Index = i;
                }
            }


            if (Index == -1)
            {
                return "";
            }
            else
            {
                string currentWords = "";
                for (int i = 0; i < strs[Index].Length; i++)
                {
                    currentWords = "";
                    for (int j = 0; j <= i; j++)
                    {
                        currentWords += strs[Index][j];
                    }
                    splitMimWords.Add(currentWords, 0);
                }

                string currentCommen = "";
                int sum = 0;
                for (int j = 0; j < splitMimWords.Count; j++)
                {
                    currentCommen = splitMimWords.ElementAt(j).Key;
                    sum = 0;
                    for (int i = 0; i < strs.Length; i++)
                    {
                        if (strs[i].Substring(0, currentCommen.Length).Contains(currentCommen))
                        {
                            sum += 1;
                        }
                        else
                        {
                            sum = -1;
                            break;
                        }
                    }

                    splitMimWords[currentCommen] = sum;
                }

                int minSize = 99999999;
                currentCommen = "";
                int currentSize;
                for (int i = 0; i < splitMimWords.Count; i++)
                {
                    currentSize = splitMimWords.ElementAt(i).Value;
                    if (minSize >= currentSize && currentSize != -1)
                    {
                        minSize = currentSize;
                        currentCommen = splitMimWords.ElementAt(i).Key;
                    }
                }
                return currentCommen;

            }

        }
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || strs == null) return "";
            int Minlength = int.MaxValue;
            for (int i = 0; i < strs.Length; i++)
            {
                Minlength = Math.Min(Minlength, strs[i].Length);
            }
            int low = 1;
            int hight = Minlength;
            int middle = 0;
            while (low <= hight)
            {
                middle = (low + hight) / 2;
                if (IsLongestCommonPrefix(strs, middle))
                {
                    low = middle + 1;
                }
                else
                {
                    hight = middle - 1;
                }
            }

            return strs[0].Substring(0, (low + hight) / 2);
        }
        public static Boolean IsLongestCommonPrefix(string[] strs, int middle)
        {
            string currentprefix = strs[0].Substring(0, middle);
            for (int i = 0; i < strs.Length; i++)
            {
                if (!strs[i].StartsWith(currentprefix)) return false;
            }
            return true;
        }
        //---------------------------------------------------------------------------------
        //5
        public static bool IsValid(string s)
        {
            if (s == "") return true;
            Stack<char> Stackdata = new Stack<char>();
            char currentChar, currentStackChar;
            for (int i = 0; i < s.Length; i++)
            {
                currentChar = s[i];
                if (currentChar == '(' || currentChar == '{' || currentChar == '[')
                {
                    Stackdata.Push(currentChar);
                }
                else
                {
                    if (Stackdata.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        currentStackChar = Stackdata.Pop();
                        if (currentStackChar == '(' && currentChar != ')')
                        {
                            return false;
                        }
                        if (currentStackChar == '[' && currentChar != ']')
                        {
                            return false;
                        }
                        if (currentStackChar == '{' && currentChar != '}')
                        {
                            return false;
                        }
                    }

                }
            }
            if (Stackdata.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //---------------------------------------------------------------------------------
        //6
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(-1);
            ListNode tail = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val > l2.val)
                {
                    tail.next = l2;
                    l2 = l2.next;

                }
                else
                {
                    tail.next = l1;
                    l1 = l1.next;
                }
                tail = tail.next;
            }

            tail.next = l1 ?? l2;
            while (head != null)
            {
                Console.WriteLine(head.val);
                head = head.next;
            }
            return head.next;
        }
        //-------------------------------------------------------------------------------
        //7
        public static int RemoveDuplicates(int[] nums)
        {
            int currentIndex = 1;
            int count = 0;
            if (nums.Length != 0)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] != nums[i - 1])
                    {
                        nums[currentIndex] = nums[i];
                        currentIndex = currentIndex + 1;
                        count++;
                    }

                }
                return count + 1;
            }
            return count;

        }
        //8
        public static int RemoveElement(int[] nums, int val)
        {
            int currentIndex = 0;
            int count = 0;
            if (nums.Length != 0)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != val)
                    {
                        nums[currentIndex] = nums[i];
                        currentIndex = currentIndex + 1;
                        count++;
                    }

                }
            }

            return count;
        }
        //9
        public static int StrStr(string haystack, string needle)
        {
            if (needle == String.Empty)
            {
                return 0;
            }
            if (!haystack.Contains(needle))
            {
                return -1;
            }
            else
            {
                return haystack.IndexOf(needle);
            }
        }
        //10
        public static int SearchInsert(int[] nums, int target)
        {
            int index = nums.Length;
            bool found = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
                if (nums[i] > target && found == false)
                {
                    index = i;
                    found = true;
                }

            }
            return index;
        }
        //11
        public static int MaxSubArray(int[] nums)
        {
            //{ -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int prevSum = 0, current = 0, maxvalue = int.MinValue;
            foreach (var num in nums)
            {
                current = num + prevSum;
                maxvalue = Math.Max(maxvalue, current);
                prevSum = Math.Max(current, 0);
            }
            return maxvalue;
        }
        //12
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //    [2,4,3]
            //[5,6,4]
            ListNode head = new ListNode();
            ListNode node = head;
            int sum = 0;
            int reminder = 0;
            while (node != null)
            {
                sum = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + reminder;
                if (sum < 10)
                {
                    node.val = sum;
                    reminder = 0;
                }
                else

                {
                    node.val = sum % 10;
                    reminder = 1;
                }
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
                if (l1 != null || l2 != null || reminder == 1)
                {
                    node.next = new ListNode();
                }
                node = node.next;



            }
            return head;
        }
        //13
        public static int LengthOfLastWord(string s)
        {
            if (s.Length == 0 || s == null || s == String.Empty)
            {
                return 0;
            }
            int counter = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    counter++;
                }
                else if (s[i] == ' ' && counter > 0)
                {
                    return counter;
                }

            }
            return counter;
        }
        //14
        public static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i] += 1;
                    return digits;
                }
                digits[i] = 0;

            }
            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;

        }
        public static int[] PlusOne2(int[] digits)
        {
            long number = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                number = number * 10 + digits[i];
            }
            number++;
            string finalResult = number.ToString();
            digits = new int[finalResult.Length];
            for (int i = 0; i < finalResult.Length; i++)
            {
                digits[i] = int.Parse(finalResult[i].ToString());
            }
            return digits;

        }
        //15
        public static string AddBinary(string a, string b)
        {
            int minLength = Math.Min(a.Length, b.Length);
            bool aIsMin = a.Length < b.Length ? true : false;

            a = ReverseStr(a);
            b = ReverseStr(b);
            string result = "";
            bool leadingValue = false;
            for (int i = 0; i < minLength; i++)
            {
                if (a[i] == '0' && b[i] == '0')
                {
                    if (leadingValue == true)
                    {
                        result += '1';
                        leadingValue = false;
                    }
                    else
                    {
                        result += '0';
                    }
                }
                else if ((a[i] == '0' && b[i] == '1') || (a[i] == '1' && b[i] == '0'))
                {
                    if (leadingValue == true)
                    {
                        result += '0';
                    }
                    else
                    {
                        result += '1';

                    }
                }
                else if (a[i] == '1' && b[i] == '1')
                {
                    if (leadingValue == true)
                    {
                        result += '1';
                    }
                    else
                    {
                        result += '0';
                    }
                    leadingValue = true;
                }
            }
            if (aIsMin)
            {
                for (int i = a.Length; i < b.Length; i++)
                {
                    if (leadingValue == true && b[i] == '0')
                    {
                        result += '1';
                        leadingValue = false;
                    }
                    else if (leadingValue == true && b[i] == '1')
                    {
                        result += '0';
                    }
                    else
                    {
                        result += b[i];

                    }
                }
            }
            else
            {
                for (int i = b.Length; i < a.Length; i++)
                {
                    if (leadingValue == true && a[i] == '0')
                    {
                        result += '1';
                        leadingValue = false;
                    }
                    else if (leadingValue == true && a[i] == '1')
                    {
                        result += '0';
                    }
                    else
                    {
                        result += a[i];

                    }
                }
            }
            if (leadingValue == true)
            {
                result += '1';
            }

            result = ReverseStr(result);
            return result;
        }

        //16
        public static int MySqrt(int x)
        {
            return Convert.ToInt32(Math.Floor(Math.Sqrt(Convert.ToDouble(x))));
        }

        //17
        public static int ClimbStairs(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1 || n == 2)
                return 1;

            int[] temp = new int[n + 1];

            temp[0] = 0;
            temp[1] = 1;
            temp[2] = 1;


            for (int i = 3; i <= n; i++)
            {
                temp[i] = temp[i - 1] + temp[i - 2] + temp[i - 3];
            }
            return temp[n];

        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
