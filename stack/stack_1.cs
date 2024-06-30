class Stack
{
    private int[] elements;
    private int top;
    private int maxSize;


    //تعريف مصفوفة بحجم يعطى من قبل المستخدم
    //انشاء مؤشر التوب 
    public Stack(int size)
    {
        maxSize = size;
        elements = new int[maxSize];
        top = -1;
    }


    //انشاء دالة لتخزين عنصر جديد داخل الستاك حيث مؤشر التوب
    public void Push(int item)
    {
        //اذا كان التوب يساوي طول المصفوفة يعني ان الستاك ممتلئ
        if (top == maxSize - 1)
        {
            Console.WriteLine("Stack overflow. Cannot push more elements.");
        }

        //اذا لم يكن ممتلئا يتم تخزين العنصر في الستاك
        else
        {
            elements[++top] = item;
        }
    }

    //انشاء دالة بوب لمسح عنصر من الستاك وعرضة للمستخدم
    public int Pop()
    {
        //اذا كان الستاك فارغ اعلم المستخدم بذلك
        if (IsEmpty())
        {
            return 0;
        }
        //اذا لم يكن فارغ يتم مسح عنصر من الستاك
        else
        {
            int item = elements[top--];
            return item;
        }
    }

    public int Peek()
    {   
        //اذا كان الستاك فارغ اعلم المستخدم بذلك
        if (IsEmpty())
        {
            return 0;
        }
        //اذا لم يكن فارغ يتم عرض العنصر عند مؤشر التوب
        else
        {
            return elements[top];
        }
    }

    //دالة للتحقق من ان الستاك ليس فارغا
    public bool IsEmpty()
    {
        return top == -1;
    }

    //دالة لعداد عناصر الستاك
      public int Count()
    {
        return top + 1;
    }

    
}

class StackSorter
{
    // ترتيب العناصر في الستاك بترتيب تنازلي
    public static Stack SortStackDescending(Stack inputStack)
    {
        Stack tempStack = new Stack(inputStack.Count());

        while (!inputStack.IsEmpty())
        {
            int temp = inputStack.Pop();

            while (!tempStack.IsEmpty() && tempStack.Peek() < temp)
            {
                inputStack.Push(tempStack.Pop());
            }

            tempStack.Push(temp);
        }

        return tempStack;
    }

    // ترتيب العناصر في الستاك بترتيب تصاعدي
    public static Stack SortStackAscending(Stack inputStack)
    {
        Stack tempStack = new Stack(inputStack.Count());

        while (!inputStack.IsEmpty())
        {
            int temp = inputStack.Pop();

            while (!tempStack.IsEmpty() && tempStack.Peek() > temp)
            {
                inputStack.Push(tempStack.Pop());
            }

            tempStack.Push(temp);
        }

        return tempStack;
    }
}
