using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication1


{
    class bod { 
        int X;
        int Y;
        int Hodnota;
        bool Zarazen;
        public bod(int x, int y) { X = x; Y = y; Hodnota = 0; Zarazen = false; }
        public void Aktivuj() { Hodnota = 1; }
        public int return_hodnota() { return Hodnota; }
        public override string ToString()
        {
            return String.Format("[{0};{1}]", X, Y);
        }
    }

    class Mapa {
        bod[,] p;
        int Velikost;
        public Mapa(int velikost)
        {
            p = new bod[velikost,velikost];
            for (int i = 0; i < velikost; i++)
            {
                for (int j = 0; j < velikost; j++)
                {
                    p[i, j] = new bod(i,j);
                }
            }
            
            Velikost = velikost;
        }        
       public void tisk_pole(Mapa po)
        {
            for (int i = 0; i < po.Velikost; i++)
            {
                for (int j = 0; j < po.Velikost; j++)
                {
                    /*System.Console.WriteLine(po.p[i, j]);*/
                    System.Console.Write(po.get_bod_value(i,j));
                }
                System.Console.Write("\n");
            }
        }
       public void set_aktive(int x, int y)
       {
           if(p[x, y].return_hodnota() == 0)
               p[x, y].Aktivuj();
           else
           {
               System.Console.Write("Zadaná hodnota je již aktivní\n");
           }
       }
        
        public int get_bod_value(int x, int y)
        {
            return p[x,y].return_hodnota();
        }
        public bod get_bod(int x, int y)
        {
            return p[x, y];
        }

        public int get_Velikost()
        {
            return Velikost;
        }


    }


    class Zila {
        public int ID;
        ArrayList obsah = new ArrayList();
        public Zila(int id, ArrayList body){
            ID = id;
            obsah = body;
        }
                
        public void tisk_count()
        {
            Console.WriteLine(obsah.Count);
        }
        public void tisk_zila()
        {

          foreach (bod i in obsah)
	        {
	            System.Console.WriteLine(i);
	        }
    
        }

        public override string ToString()
        {
            return String.Format("ID: {0}", ID);
        }
    }

    class Hledej_zily {
        ArrayList nalazene_zily = new ArrayList();
        ArrayList aktual_body = new ArrayList();
        Mapa mapa;
        public Hledej_zily(Mapa map)
        {
            mapa = map;
            algorimus(map);
        }

        public void pridej_policko(bod p)
        {
            aktual_body.Add(p);
        }

        public void pridej_zilu(ArrayList body)
        {
            int new_ID = (nalazene_zily.Count)+1;
            Zila zila = new Zila(new_ID, body);
            nalazene_zily.Add(zila);
            nalazene_zily.Clear();
            /*to do vyprazdni ArrayList*/
        }

        public void tisk_zil()
        {
            foreach (Zila i in nalazene_zily)
            {
                System.Console.WriteLine(i);
            }
        }


        public void algorimus(Mapa po)
        {
            for (int i = 0; i < po.get_Velikost(); i++)
            {
                for (int j = 0; j < po.get_Velikost(); j++)
                {
                    if (po.get_bod_value(i, j) == 1)
                    {
                        pridej_policko(po.get_bod(i, j));
                    }
                }
            }
            pridej_zilu(aktual_body);
        }


        public void vnitrni_algorimus(Mapa po,bod b, int value)
        {
           
        }

    
    
    }

    
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Mapa pole = new Mapa(10);
            
            pole.set_aktive(2, 4);
            pole.set_aktive(2, 5);
            pole.set_aktive(2, 6);
            pole.set_aktive(3, 4);
            pole.set_aktive(3, 5);
            pole.set_aktive(3, 6);

            pole.set_aktive(6, 6);
            pole.set_aktive(6, 7);
            pole.set_aktive(6, 8);
            pole.set_aktive(7, 6);
            pole.set_aktive(7, 7);
            pole.set_aktive(7, 8);

            pole.tisk_pole(pole);
            Hledej_zily h = new Hledej_zily(pole);
            h.tisk_zil();
         
        }
    }
}
