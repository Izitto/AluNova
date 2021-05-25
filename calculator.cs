using System;

INT calculator(double xwidth,double xheight){
    double needed= 20;
    double have=13.3;
    double chosenSize;
    double arlist = new ArrayList()
                {
                    19.0,
                    20.5,
                    120.4,
                    20.3
                };

    double prevWaste=120.3;

    foreach (var val in arlist){
        double waste=(val)-(needed);
        if(waste<prevWaste){
            prevWaste=waste;
            chosenSize=val;
        }

    }
    
    Console.Write(chosenSize);
    
    
}