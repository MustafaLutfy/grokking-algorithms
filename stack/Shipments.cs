namespace stack;


class Shipment
{
    public int ID { get; private set; }
    public int Order { get; private set; }
    
    public Shipment(int id, int order)
    {
        ID = id;
        Order = order;
    }
}

class ShipmentStack
{
    public static void UnloadShipments(Stack<Shipment> shipments)
    {
        // Base case: اذا كان الستاك فارغ توقف
        if (shipments.Count == 0)
        {
            return;
        }

        // تفريغ عنصر الستاك وتخزينه في متغير محفوظ
        Shipment topShipment = shipments.Pop();
        Console.WriteLine($"Unloaded {topShipment.ID}");

        // recursionمناداة الدالة بعدالانتهاء لتحقيق عملية  ال 
        UnloadShipments(shipments);
    }
}