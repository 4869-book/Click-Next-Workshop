using System;
class Workshop
{
    static void Main()
    {
        SecToTime(133210);

    }

    //1
    static void SumArray(int[] arr,int sum)
    {
        for(int i=0;i<arr.Length;i++)
        {
            for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]+arr[j]==sum)
                    {
                        Console.WriteLine(arr[i]+","+arr[j]);
                        arr[i] = sum;
                        arr[j] = sum;
                    }
                }
        }
    }   

    //2
    static void MatchString(String str1, String str2)
    {
        if(str1.Length==str2.Length)
        {
            Console.WriteLine(Stringsort(str1)==Stringsort(str2));
        }else
        {
            Console.WriteLine("False");
        }
    }

    public static String ConvertToUpperCase(String input)  
      {  
         String output = "";  
         for (int i = 0; i < input.Length; i++)  
         {  
            if (input[i] >= 'a' && input[i] <= 'z')  
            {  
               output += (char)(input[i] - 'a' + 'A');  
            }  
            else  
               output += input[i];  
         }  
         return output;  
      } 

    public static string Stringsort(String str)
    {
        char key;
        string upperstr = ConvertToUpperCase(str);
        char[] charstr = upperstr.ToCharArray();
        int i,j;
        for(i=1;i<str.Length;i++)
        {
            key=charstr[i];
            j=i-1;
            while(j>=0 && charstr[j]>key)
            {
                charstr[j+1]= charstr[j];
                j=j-1;
            }
            charstr[j+1]=key;
        }

        string charsStr = new string(charstr);  

        return charsStr;
    }

    //3
    static void DateShow(int[] arr)
    {
        bool flag = false;
        int end = 0;
        int i,j;
        List<string> dateList = new List<string>();
        for(i=0;i<arr.Length;i++)
        {
            for(j=1;j<arr.Length-i;j++)
            {
                if(arr[i]+j==arr[i+j]){
                    end = arr[i+j];
                    flag = true;
                }else{
                    if(flag){
                         dateList.Add((arr[i]+"-"+end).ToString());
                        flag=false;
                    }else{
                        dateList.Add(arr[i].ToString());
                    }
                    
                    i=i+j-1;
                    break;
                }
                
            }
            if(i+j==arr.Length)
            {
                dateList.Add((arr[i]+"-"+end).ToString());
                break;
            }
        }
        // dateList.ForEach(dateList => Console.Write(dateList + ","));
        Console.WriteLine(string.Join(",", dateList));
    }

    //4
    static void ShowDimond(int row){
        for(int i=row;i>0;i--)
        {
            for(int j=0;j<row-i;j++)
            {
                Console.Write(" ");
            }
            for(int j=0;j<(i*2)-1;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }

    //5
    static void NumberTriangle(int row)
    {
        int[] number = {1,2,3,4,5,6,7,8,9,0};
        int temp = 0;
        if(row>0 && row < 5)
        {
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<row-i;j++)
                {
                    Console.Write(" ");
                }
                for(int j=0;j<i+1;j++)
                {
                    Console.Write(number[temp]+" ");
                    temp++;
                }
                Console.WriteLine("");
            }
        }else{
            Console.WriteLine("parameter must be 1-4");
        }
    }

        //6
    static void DescendingSort(int[] arr)
    {
        int i,j,key;
        for(i=1;i<arr.Length;i++)
        {
            key=arr[i];
            j=i-1;
            while(j>=0 && arr[j]>key)
            {
                arr[j+1]= arr[j];
                j=j-1;
            }
            arr[j+1]=key;
        }
        Console.WriteLine(string.Join(",", arr));
    }

    //7
    static void SecToTime(int sec)
    {
        int h = 0;
        int m = 0;
        int s = 0;

        s=sec%60;
        m=(sec/60)%60;
        h=(sec/60)/60;

        Console.Write(h.ToString("00")+":"+m.ToString("00")+":"+s.ToString("00"));

    }

    //8
    static void Change(int price)
    {
        int change = 1000-price;
        Console.WriteLine("จำนวนเงินทอน "+change+" บาท");
        Console.WriteLine("500 "+(change/500)+" 1 ใบ");
        Console.WriteLine("100 "+((change%500)/100)+" ใบ");
        Console.WriteLine("50  "+((change%100)/50)+" ใบ");
        Console.WriteLine("10  "+((change%50)/10)+" เหรียญ");
        Console.WriteLine("5   "+((change%10)/5)+" เหรียญ");
        Console.WriteLine("1   "+(change%5)+" เหรียญ");
    }

    //9
    static void ReversString(string str)
    {
        List<string> temp = new List<string>();
        int count=0;
        for(int i=0;i<str.Length;i++)
        {
            if(str[i] == ' ')
            {
                for(int j=i-1;j>=i-count;j--)
                {
                    temp.Add(str[j].ToString());
                }
                temp.Add(" ");
                count=0;
            }else if(i == str.Length-1)
            {
                for(int j=i;j>=i-count;j--)
                {
                    temp.Add(str[j].ToString());
                }
                temp.Add(" ");
                count=0;
            }else
            {
                count++;
                
            }
        }
        temp.ForEach(temp => Console.Write(temp));
    }
    
    //10
    static void ShowTriangle(int row){
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<row-i;j++)
            {
                Console.Write(" ");
            }
            for(int j=0;j<(i*2)+1;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }

    //11
    static void AscendingSort(int[] arr)
    {
        int i,j,key;
        for(i=1;i<arr.Length;i++)
        {
            key=arr[i];
            j=i-1;
            while(j>=0 && arr[j]<key)
            {
                arr[j+1]= arr[j];
                j=j-1;
            }
            arr[j+1]=key;
        }
        Console.WriteLine(string.Join(",", arr));
    }

}