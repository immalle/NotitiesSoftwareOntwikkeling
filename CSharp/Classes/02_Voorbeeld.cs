using System;

class Varken {

  private double gewicht;
  
  public double Gewicht {
    get {
      return gewicht;
    }
    set {
      gewicht = value;
    }
  }
}

class Koe {
  private double gewicht;
  
  public double Gewicht {
    get {
      return gewicht;
    }
  }
}

class Paard {
  public double Gewicht { get; set; };
  
  public string Info {
    get {
      return "Het paard weegt " + this.Gewicht + " kg";
    }
  }
} 


class Program {
  static void Main() {
    Varken piggie = new Varken();

    piggie.Gewicht = 90.5;
    double g = piggie.Gewicht;
    
    Console.WriteLine(g);
    
    Koe bella = new Koe();
    
    //bella.Gewicht = 102.3; // dit geeft een foutmelding! Controleer!
    Console.WriteLine(bella.Gewicht);
    
    Paard balthazar = new Paard();
    balthazar.Gewicht = 93.8;
    Console.WriteLine(balthazar.Gewicht);
    Console.WriteLine(balthazar.Info);
  }
}
