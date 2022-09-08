using System;
public class exchnge{
    public static void money_in(){
        double Money ;
        Console.WriteLine("Please input money :");
        Money = double.Parse(Console.ReadLine()); 
        double lagpun = Money - (Money % 1000);
        double lagroi = (Money - lagpun) -(Money % 100);
        double lagsib = (Money - (lagpun+lagroi)-(Money % 10));
        double lagnuang = (Money - (lagpun+lagroi+lagsib)-(Money % 1));
        double lagstang = (Money % 1);
        tronpun(ref Money);
        tronroi(ref Money);
        tronsib(ref Money);
        tronnuang(ref Money);
        tronsatang(ref Money);
    

    }

    public static double tronpun(ref double Money){
        double tronpun;
         double lagpun = Money - (Money % 1000);
    tronoun = lagpun/1000;
    Console.WriteLine("1000 :{0} ",tronpun);
    Money = Money - lagpun;
    return Money;     

    }
    public static double tronroi(ref double Money){
        double tronroi;
        double tronharoi;
        double lagpun = Money - (Money % 1000);
        double lagroi = (Money - lagpun) - (Money % 100);
    tronharoi = lagroi/500;
    Money = (Money -(500*tronharoi));
    
    }
}