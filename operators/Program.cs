//@yesyu2 

int x = 3;
    int y = 4;
    y = y + 2 ;
    
    Console.WriteLine(y);
    y/=2;
    Console.WriteLine(y);
   y/=1;
    Console.WriteLine(y);
    x*=2;
    Console.WriteLine(x);


    Console.WriteLine("|-------------Mantıksal Operatörler-------------|");
    bool isSucces = true ;
    bool isCompleted = false ;

    if(isSucces && isCompleted) 
        Console.WriteLine("Pickle Rick!");

   if(isSucces || isCompleted) 
        Console.Write("deClare!");

    if(isSucces && !isCompleted) 
        Console.WriteLine("zzZZZ!");
       
        Console.WriteLine("|-------------İlişkisel Operatörler-------------|");
        int a = 3 ;
        int b = 4 ;
        bool sonuc = a<b ;
        Console.WriteLine(sonuc);
        sonuc = a>b ;  
        Console.WriteLine(sonuc);
        sonuc = a>=b ;
        Console.WriteLine(sonuc);
        sonuc = a<=b ;
        Console.WriteLine(sonuc);
        sonuc = a==b ;
        Console.WriteLine(sonuc);
        sonuc = a!=b ;
        Console.WriteLine(sonuc);
        
        Console.WriteLine("|-------------Matematiksel Operatörler-------------|");

        int sayi1   = 10 ; 
        int sayi2   = 5 ;
        int sonuc1  =  sayi1/sayi2 ; 
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 * sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 + sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1+=1 ;
        Console.WriteLine(sonuc1);
        
        
        Console.WriteLine("|-------------Mod Alma-------------|");
        int sonuc2 = 20%3 ;
        Console.WriteLine(sonuc2);