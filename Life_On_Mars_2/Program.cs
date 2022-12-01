using System;
using System.IO;

namespace Life_On_Mars_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int OPnumber = 0;
            char[] blobDNAarray = new char[10000];
            while (OPnumber <= 17)
            {
                switch (OPnumber)
                {
                    case 0: // main menu
                        Console.Clear();
                        Console.WriteLine("Operation 1   ==>  Load a DNA sequence from a file");                                   //Progress: DONE               => Shared
                        Console.WriteLine("Operation 2   ==>  Load a DNA sequence from a string (type in console)");               //Progress: DONE               => Islam RAMAZANOV
                        Console.WriteLine("Operation 3   ==>  Generate random DNA sequence of a BLOB");                            //Progress: DONE               => Islam RAMAZANOV
                        Console.WriteLine("Operation 4   ==>  Check DNA gene structure");                                          //Progress: HAVE SOME PROBLEMS => Islam RAMAZANOV
                        Console.WriteLine("Operation 5   ==>  Check DNA of BLOB organism");                                        //Progress: DONE               => Çağrı AYDIN & Islam RAMAZANOV
                        Console.WriteLine("Operation 6   ==>  Produce complement of a DNA sequence");                              //Progress: DONE               => Çağrı AYDIN
                        Console.WriteLine("Operation 7   ==>  Determine amino acids");                                             //Progress: DONE               => Çağrı AYDIN
                        Console.WriteLine("Operation 8   ==>  Delete codons ");                                                    //Progress: DONE               => Çağrı AYDIN
                        Console.WriteLine("Operation 9   ==>  Insert codons ");                                                    //Progress: DONE               => Çağrı AYDIN
                        Console.WriteLine("Operation 10  ==>  Find codons ");                                                      //Progress: DONE               => İsra ÇEVİK
                        Console.WriteLine("Operation 11  ==>  Reverse codons ");                                                   //Progress: DONE               => İsra ÇEVİK
                        Console.WriteLine("Operation 12  ==>  Find the number of genes in a DNA strand (BLOB or not)");            //Progress: DONE               => İsra ÇEVİK
                        Console.WriteLine("Operation 13  ==>  Find the shortest gene in a DNA strand");                            //Progress: DONE               => İsra ÇEVİK
                        Console.WriteLine("Operation 14  ==>  Find the longest gene in a DNA strand");                             //Progress: DONE               => Eilyar RAZZAGHPOUR
                        Console.WriteLine("Operation 15  ==>  Find the most repeated n-nucleotide sequence in a DNA strand ");     //Progress: DONE               => Eilyar RAZZAGHPOUR
                        Console.WriteLine("Operation 16  ==>  Hydrogen bond statistics for a DNA strand");                         //Progress: DONE               => Çağrı AYDIN 
                        Console.WriteLine("Operation 17  ==>  Simulate BLOB generations using DNA strand 1 and 2 ");               //Progress: ON GOING           => Eilyar RAZZAGHPOUR
                        Console.WriteLine("");
                        Console.Write("Current DNA strand is : ");
                        for (int i = 0; i < blobDNAarray.Length; i++)
                        {
                            Console.Write(blobDNAarray[i]);
                        }
                        Console.WriteLine("\nEnter a operation number to run a operation:");
                        OPnumber = Convert.ToInt16(Console.ReadLine());
                        break;
                    //##############################################################################################################################


                    case 1://============================================= O P A R A T I O N 1 =====================================================
                        Console.Clear();

                        string blobDNA = System.IO.File.ReadAllText(@"C:\Users\ASUS\Desktop\Life On Mars\dna1.txt");  //getting DNA strand from txt file

                        Console.WriteLine("==>  OPERATION 1");
                        Console.WriteLine("dna1.txt: " + blobDNA);  //writing txt file content
                        Console.WriteLine("Current DNA is : " + blobDNA);
                        //converting string into a array

                        blobDNAarray = blobDNA.ToCharArray();       //making txt file chars to char array
                        OPnumber = 0;                               //for looping 
                        Console.ReadLine();                         //for seeing the results
                        break;
                    //##############################################################################################################################


                    case 2://============================================= O P A R A T I O N 2 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 2");
                        Console.WriteLine("Please enter codon sequence you want to use: ");
                        string readedDNA = Console.ReadLine();
                        readedDNA = readedDNA.ToUpper();
                        Console.WriteLine("Current DNA is : " + readedDNA);
                        blobDNAarray = readedDNA.ToCharArray();
                        OPnumber = 0;
                        Console.ReadLine();
                        break;
                    //##############################################################################################################################


                    case 3://============================================= O P A R A T I O N 3 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 3");
                        Console.WriteLine("Enter: Gender of the BLOB");
                        char gender = Convert.ToChar(Console.ReadLine());

                        Random rnd = new Random();

                        char[] nucleotide = { 'A', 'T', 'C', 'G' };

                        int number_of_genes = rnd.Next(2, 8);

                        int[] codon_numbers = new int[8];

                        char[] dna_strand_char_array = new char[300];

                        for (int i = 0; i < 8; i++)
                        {
                            if (i == 0)
                            {
                                codon_numbers[i] = 4;
                            }
                            else
                            {
                                codon_numbers[i] = rnd.Next(3, 9);
                            }

                        }
                        int dna_strand_Lenght = 0;

                        // Gene of gender creation
                        for (int i = 0; i < number_of_genes; i++)
                        {
                            dna_strand_Lenght += codon_numbers[i] * 3;
                        }
                        for (int i = 0; i < 12; i++)
                        {
                            if (i == 0)
                            {
                                dna_strand_char_array[i] = 'A';
                            }
                            if (i == 1)
                            {
                                dna_strand_char_array[i] = 'T';
                            }
                            if (i == 2)
                            {
                                dna_strand_char_array[i] = 'G';
                            }
                            if (i == 9)
                            {
                                dna_strand_char_array[i] = 'T';
                            }
                            if (i == 10)
                            {
                                dna_strand_char_array[i] = 'A';
                            }
                            if (i == 11)
                            {
                                dna_strand_char_array[i] = 'G';
                            }
                            if (i == 3)
                            {
                                if (gender == 'f')
                                {
                                    dna_strand_char_array[i] = nucleotide[rnd.Next(0, 2)];
                                    dna_strand_char_array[i + 1] = dna_strand_char_array[i];
                                    dna_strand_char_array[i + 2] = dna_strand_char_array[i];
                                }
                                else
                                {
                                    dna_strand_char_array[i] = nucleotide[rnd.Next(0, 4)];
                                    dna_strand_char_array[i + 1] = nucleotide[i];
                                    dna_strand_char_array[i + 2] = nucleotide[i];
                                    dna_strand_char_array[i] = dna_strand_char_array[i + 1];
                                }
                            }
                            if (i == 6)
                            {
                                if (gender == 'f')
                                {
                                    dna_strand_char_array[i] = nucleotide[rnd.Next(0, 2)];
                                    dna_strand_char_array[i + 1] = dna_strand_char_array[i];
                                    dna_strand_char_array[i + 2] = dna_strand_char_array[i];
                                }
                                else
                                {
                                    if (dna_strand_char_array[i - 3] == 'A' || dna_strand_char_array[i - 3] == 'T')
                                    {
                                        dna_strand_char_array[i] = nucleotide[rnd.Next(2, 4)];
                                        dna_strand_char_array[i + 1] = dna_strand_char_array[i];
                                        dna_strand_char_array[i + 2] = dna_strand_char_array[i];
                                    }
                                    else
                                    {
                                        dna_strand_char_array[i] = nucleotide[rnd.Next(0, 2)];
                                        dna_strand_char_array[i + 1] = dna_strand_char_array[i];
                                        dna_strand_char_array[i + 2] = dna_strand_char_array[i];
                                    }
                                }

                            }
                        }

                        // other gene creations
                        char[] other_genes = null;
                        other_genes = Random_genes(codon_numbers[1], nucleotide);


                        for (int i = 12; i < other_genes.Length + 12; i++)
                        {
                            dna_strand_char_array[i] = other_genes[i - 12];
                        }


                        // other gene creations
                        if (number_of_genes > 1)
                        {
                            other_genes = Random_genes(codon_numbers[2], nucleotide);

                            for (int i = 12 + codon_numbers[1] * 3; i < 12 + codon_numbers[1] + codon_numbers[2]; i++)
                            {
                                dna_strand_char_array[i] = other_genes[i - (12 + codon_numbers[1] * 3)];
                            }
                        }
                        blobDNAarray = dna_strand_char_array;
                        int counter_op3 = 0;
                        foreach (var var in dna_strand_char_array)
                        {
                            counter_op3++;
                            Console.Write(Convert.ToString(var));
                            if (counter_op3 % 3 == 0)
                            {
                                Console.Write(" ");
                            }
                        }
                

                    static char[] Random_genes(int codon_numbers, char[] nucleotide)
                    {
                    Random rnd = new Random();
                    char[] other_genes = new char[codon_numbers * 3];
                    other_genes[0] = 'A'; other_genes[1] = 'T'; other_genes[2] = 'G';

                    for (int i = 3; i < other_genes.Length - 3; i++)
                    {
                        int random;
                        other_genes[i] = nucleotide[rnd.Next(0, 4)];
                        if (i % 3 == 2)
                        {
                            for (int j = 0; j < 1;)
                            {
                                if ((other_genes[i - 2] == 'A' && other_genes[i - 1] == 'T' && other_genes[i] == 'G') ||
                                    (other_genes[i - 2] == 'T' && other_genes[i - 1] == 'A' && other_genes[i] == 'A') ||
                                    (other_genes[i - 2] == 'T' && other_genes[i - 1] == 'G' && other_genes[i] == 'A') ||
                                    (other_genes[i - 2] == 'T' && other_genes[i - 1] == 'A' && other_genes[i] == 'G'))
                                {
                                    i -= 3;
                                    break;
                                }
                                else
                                {
                                    break;
                                }

                            }
                        }
                    }
                    int r = rnd.Next(0, 3);
                    if (r == 0)
                    {
                        other_genes[other_genes.Length - 3] = 'T';
                        other_genes[other_genes.Length - 2] = 'A';
                        other_genes[other_genes.Length - 1] = 'A';
                    }
                    else if (r == 1)
                    {
                        other_genes[other_genes.Length - 3] = 'T';
                        other_genes[other_genes.Length - 2] = 'A';
                        other_genes[other_genes.Length - 1] = 'G';
                    }
                    else
                    {
                        other_genes[other_genes.Length - 3] = 'T';
                        other_genes[other_genes.Length - 3] = 'G';
                        other_genes[other_genes.Length - 3] = 'A';
                    }
                    return other_genes;
                            
                    }
                        Console.ReadLine();
                        OPnumber = 0;
                        break; 
                    //##############################################################################################################################

                    
                    case 4://============================================= O P A R A T I O N 4 =====================================================


                        
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 4");
                        Console.Write("\nDNA strand is : ");
                        for (int i = 0; i < blobDNAarray.Length; i++)
                        {
                            Console.Write(blobDNAarray[i]);
                        }


                        // Declare a char array.
                        char[] strand_of_dna1 = new char[blobDNAarray.Length];
                        strand_of_dna1 = blobDNAarray;

                        // Convert string to char array!
                        for (int i = 0; i < strand_of_dna1.Length; i++) strand_of_dna1[i] = strand_of_dna1[i];

                        // Check length of the DNA strand % 3 is 0 or not! 
                        int divisibleWithThree = strand_of_dna1.Length;
                        Console.WriteLine("\nLength of the DNA Strand is: " + Convert.ToString(divisibleWithThree));

                        // Find how many times start codon "ATG" and All stop codons repeated in a DNA strand! And save start index values of start and stop codons to integer arrays.
                        int geneCounter = 0;
                        int stopCodonCounter = 0;
                        int[] startCodonIndex = new int[7];
                        int[] stopCodonIndex = new int[7];

                        for (int i = 0; i < strand_of_dna1.Length; i += 3)
                        {
                            if (strand_of_dna1[i] == 'A' && strand_of_dna1[i + 1] == 'T' && strand_of_dna1[i + 2] == 'G')
                            {
                                startCodonIndex[geneCounter] = i;
                                geneCounter++;
                            }

                            if ((strand_of_dna1[i] == 'T' && strand_of_dna1[i + 1] == 'A' && strand_of_dna1[i + 2] == 'A') ||
                                (strand_of_dna1[i] == 'T' && strand_of_dna1[i + 1] == 'A' && strand_of_dna1[i + 2] == 'G') ||
                                (strand_of_dna1[i] == 'T' && strand_of_dna1[i + 1] == 'G' && strand_of_dna1[i + 2] == 'A'))
                            {
                                stopCodonIndex[stopCodonCounter] = i;
                                stopCodonCounter++;
                            }
                        }

                        Console.WriteLine("ATG repeated: " + Convert.ToString(geneCounter) +
                                          " times.\nStop codons repeated: " + Convert.ToString(stopCodonCounter) +
                                          " times.");

                        Console.Write("Start codon indexes are: ");
                        for (int i = 0; i < startCodonIndex.Length; i++)
                        {
                            Console.Write(startCodonIndex[i]+" ");
                        }

                        Console.Write("\nStop codon indexes are: ");
                        for (int i = 0; i < stopCodonIndex.Length; i++)
                        {
                            Console.Write(stopCodonIndex[i]+" ");
                        }

                        //DNA STRUCTURE CONTROL PART

                        // First DNA check! Every codons consists of 3 nucleotide, therefore if it is a DNA strand it have to be 
                        // divided by 3. Check divided by 3!

                        if (divisibleWithThree % 3 != 0)
                        {
                            Console.WriteLine(
                                "\nCodon structure error. At least one of the codon has less than 3 nucleotide!");
                            Environment.Exit(0);
                        }

                        //Equality of start and stop codons checked!
                        if (geneCounter != stopCodonCounter)
                        {
                            Console.WriteLine("\nGene structure error. Start and stop codon numbers have to be equal!");
                            Environment.Exit(0);
                        }

                        // Check the  sequence of start and stop codons.
                        for (int i = 0; i < geneCounter; i++)
                        {
                            if (startCodonIndex[i] > stopCodonIndex[i])
                            {
                                Console.WriteLine(
                                    "\nGene structure error. Sequence of start and stop codons are failed.");
                                Environment.Exit(0);
                            }
                        }

                        // Check stop codons are come before the ATG codons.
                        for (int i = 0; i < stopCodonCounter - 1; i++)
                        {
                            if (strand_of_dna1[stopCodonIndex[i] + 3] == 'A' && strand_of_dna1[stopCodonIndex[i] + 4] == 'T' &&
                                strand_of_dna1[stopCodonIndex[i] + 5] == 'G')
                            {
                                Console.WriteLine("\nStop codons are come before the ATG codons.");
                            }
                            else
                            {
                                Console.WriteLine("\nGene structure error caused sequential error! Stop codon have to be followed up with \"ATG codon!\"");
                                Console.Write(Convert.ToString(i + 1) + ". Stop codon follower \"ATG\" has failed.");
                                Environment.Exit(0);
                            }
                        }

                        // Check last codon is a stop codon!
                        if ((strand_of_dna1[strand_of_dna1.Length - 3] == 'T' && strand_of_dna1[strand_of_dna1.Length - 2] == 'A' &&
                             strand_of_dna1[strand_of_dna1.Length - 1] == 'A') ||
                            (strand_of_dna1[strand_of_dna1.Length - 3] == 'T' && strand_of_dna1[strand_of_dna1.Length - 2] == 'A' &&
                             strand_of_dna1[strand_of_dna1.Length - 1] == 'G') || (strand_of_dna1[strand_of_dna1.Length - 3] == 'T' &&
                                                                           strand_of_dna1[strand_of_dna1.Length - 2] == 'G' &&
                                                                           strand_of_dna1[strand_of_dna1.Length - 1] == 'A'))
                        {
                            Console.WriteLine("\nLast codon sequence is suitable!");
                        }
                        else
                        {
                            Console.WriteLine("\nGene structure error because of the last Codon error.");
                            Environment.Exit(0);
                        }

                        // Check first codon is a start codon!
                        if (strand_of_dna1[1] == 'A' && strand_of_dna1[2] == 'T' && strand_of_dna1[3] == 'G')
                        {
                            Console.WriteLine("\nFirst codon sequence is suitable!");
                        }
                        else
                        {
                            Console.WriteLine("\nGene structure error because of the first Codon error.");
                            Environment.Exit(0);
                        }

                        Console.WriteLine("\nEvery gene structure is OK.");

                        Console.ReadLine();
                        OPnumber = 0;



                        break;
                        //##############################################################################################################################
                
                
                        

                        break;
                    //##############################################################################################################################

                    
                    case 5://============================================= O P A R A T I O N 5 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 5");

                        Console.Write("Current DNA is : ");
                        string[] OP5_Show = new string[blobDNAarray.Length / 3];
                        int op5i = 0;
                        for (int i = 0; i < blobDNAarray.Length; i = i + 3)
                        {
                            OP5_Show[op5i] = blobDNAarray[i].ToString() + blobDNAarray[i + 1].ToString() + blobDNAarray[i + 2].ToString();
                            op5i++;
                        }
                        for (int i = 0; i < OP5_Show.Length; i++)
                        {
                            Console.Write(OP5_Show[i] + " ");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                        bool flag_5_1 = false;
                        bool flag_5_2 = false;
                        bool flag_5_3 = false;
                        bool flag_5_4 = false;
                        bool flag_5_5 = false;
                        bool flag_5_6 = true;
                        bool flag_5_7 = true;

                        if (blobDNAarray[0]=='A' & blobDNAarray[1] == 'T'& blobDNAarray[2] == 'G') //checking start codon
                        {
                            flag_5_1 = true;
                        }
                        else
                        {
                            Console.Write("Starting codon error. ");
                        }
                        if (blobDNAarray[3] == 'A' & blobDNAarray[4] == 'A' & blobDNAarray[5] == 'A' | blobDNAarray[3] == 'T' & blobDNAarray[4] == 'T' & blobDNAarray[5] == 'T' | blobDNAarray[3] == 'G' & blobDNAarray[4] == 'G' & blobDNAarray[5] == 'G' | blobDNAarray[3] == 'C' & blobDNAarray[4] == 'C' & blobDNAarray[5] == 'C') //checking first gender codon
                        {
                            flag_5_2 = true;
                        }
                        else
                        {
                            Console.Write("First gender codon error. ");
                        }
                        if (blobDNAarray[6] == 'A' & blobDNAarray[7] == 'A' & blobDNAarray[8] == 'A' | blobDNAarray[6] == 'T' & blobDNAarray[7] == 'T' & blobDNAarray[8] == 'T' | blobDNAarray[6] == 'G' & blobDNAarray[7] == 'G' & blobDNAarray[8] == 'G' | blobDNAarray[6] == 'C' & blobDNAarray[7] == 'C' & blobDNAarray[8] == 'C') //checking second gender codon
                        {
                            flag_5_3 = true;
                        }
                        else
                        {
                            Console.Write("Second gender codon error. ");
                        }
                        if (blobDNAarray[9] == 'T' & blobDNAarray[10] == 'A' & blobDNAarray[11] == 'G')
                        {
                            flag_5_4 = true;
                        }
                        else
                        {
                            Console.Write("Fourth codon error. ");
                        }
                        if (blobDNAarray[12] == 'A' & blobDNAarray[13] == 'T' & blobDNAarray[14] == 'G')
                        {
                            flag_5_5 = true;
                        }
                        else
                        {
                            Console.WriteLine("Second starter codon error. ");
                        }
                        int counter_5ATG = 0;
                        int counter_5TAA = 0;
                        int counter_5TGA = 0;
                        int counter_5TAG = 0;
                        for (int i = 0; i < blobDNAarray.Length; i = i + 3)
                        {
                            if (blobDNAarray[i] == 'A' & blobDNAarray[i + 1] == 'T' & blobDNAarray[i + 2] == 'G')
                            {
                                counter_5ATG++;
                            }
                            if (blobDNAarray[i] == 'T' & blobDNAarray[i + 1] == 'A' & blobDNAarray[i + 2] == 'A')
                            {
                                counter_5TAA++;
                            }
                            if (blobDNAarray[i] == 'T' & blobDNAarray[i + 1] == 'G' & blobDNAarray[i + 2] == 'A')
                            {
                                counter_5TGA++;
                            }
                            if (blobDNAarray[i] == 'T' & blobDNAarray[i + 1] == 'A' & blobDNAarray[i + 2] == 'G')
                            {
                                counter_5TAG++;
                            }
                        }
                        if (counter_5ATG != counter_5TAA + counter_5TAG + counter_5TGA | counter_5ATG < 3 | counter_5ATG > 8)
                        {
                            Console.WriteLine("Number of genes error.");
                            flag_5_6 = false;
                        }
                        if (blobDNAarray.Length/3<1 | blobDNAarray.Length/3>7)
                        {
                            Console.WriteLine("Number of codons error. ");
                            flag_5_7 = false;
                        }
                        if (blobDNAarray[blobDNAarray.Length - 3] == 'T' & blobDNAarray[blobDNAarray.Length - 2] == 'A' & blobDNAarray[blobDNAarray.Length - 1] == 'A' | blobDNAarray[blobDNAarray.Length - 3] == 'T' & blobDNAarray[blobDNAarray.Length - 2] == 'A' & blobDNAarray[blobDNAarray.Length - 1] == 'G' | blobDNAarray[blobDNAarray.Length - 3] == 'T' & blobDNAarray[blobDNAarray.Length - 2] == 'G' & blobDNAarray[blobDNAarray.Length - 1] == 'A' & flag_5_1==true&flag_5_2==true&flag_5_3==true&flag_5_4==true&flag_5_5==true&flag_5_6==false&flag_5_7==false)
                        {
                            Console.WriteLine("Blob is OK. ");
                        }
                        
                        


                        Console.ReadLine();
                        OPnumber = 0;
                        break;
                    //##############################################################################################################################

                    
                    case 6://============================================= O P A R A T I O N 6 =====================================================
                        Console.Clear();                                                       //Clearing post proccess
                        Console.WriteLine("==>  OPERATION 6 \n");
                        char[] complementDNA = blobDNAarray;                                   //creating a new char array for making a complement char array
                        Console.Write("DNA strand             : ");
                        for (int i = 0; i < complementDNA.Length; i++)                         //Writing main DNA strand                  
                        {
                            Console.Write(complementDNA[i]);
                        }
                        try                                                                    //I used try catch because after the and of array it gives exeption and exits the program
                        {                                                                      
                            int op6counter = 0;
                            while (op6counter < complementDNA.Length)
                            {
                                if (complementDNA[op6counter] == 'A')
                                {
                                    complementDNA[op6counter] = 'T';
                                    op6counter++;
                                }
                                if (complementDNA[op6counter] == 'T')
                                {
                                    complementDNA[op6counter] = 'A';
                                    op6counter++;
                                }
                                if (complementDNA[op6counter] == 'G')
                                {
                                    complementDNA[op6counter] = 'C';
                                    op6counter++;
                                }
                                if (complementDNA[op6counter] == 'C')
                                {
                                    complementDNA[op6counter] = 'G';
                                    op6counter++;
                                }
                            }
                        }
                        catch (Exception)
                        {

                            Console.Write("\nComplement of DNA is   : ");                     //Writing complement DNA
                        }
                        for (int i = 0; i < complementDNA.Length; i++)
                        {
                            Console.Write(complementDNA[i]);
                        }

                        blobDNAarray = complementDNA;
                        Console.Write("\nCurrent DNA sequance is: ");                         //Writing current DNA
                        for (int i = 0; i < blobDNAarray.Length; i++)
                        {
                            Console.Write(blobDNAarray[i]);
                        }
                        OPnumber = 0;
                        Console.ReadLine();
                        break;
                    //##############################################################################################################################

                    
                    case 7://============================================= O P A R A T I O N 7 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 7 \n");
                        string[] aminoacids = { "Ala", "Arg", "Asn", "Asp", "Cys", "Gln", "Glu", "Gly", "His", "Ile", "Leu", "Lys", "Met", "Phe", "Pro", "Ser", "Thr", "Trp", "Tyr", "Val", "END" };

                        //translating string into codons and writing them like codons 
                        string[] AAcodons = new string[blobDNAarray.Length / 3];                   
                        int a_op7 = 0;
                        for (int i = 0; i < blobDNAarray.Length; i = i + 3)
                        {
                            AAcodons[a_op7] = blobDNAarray[i].ToString() + blobDNAarray[i + 1].ToString() + blobDNAarray[i + 2].ToString();

                            a_op7++;
                        }
                        Console.WriteLine("");
                        //---------------------------------------------------------------------------------------------------------------------

                        Console.Write("DNA strand  :");
                        for (int i = 0; i < AAcodons.Length; i++)
                        {
                            Console.Write(AAcodons[i] + " ");
                        }
                        //Determine amino acids
                        Console.Write("\nAmino acids :");
                        int i_7 = 0;
                        try
                        {
                            while (i_7 < blobDNAarray.Length)
                            {
                                if (blobDNAarray[i_7] == 'A')      // Starts with Adenin
                                {
                                    if (blobDNAarray[i_7 + 1] == 'A') //AA
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G')  //AAA & AAG
                                        {
                                            Console.Write("Lys ");
                                            i_7 = i_7 + 3;
                                        }
                                        if (blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //AAT & AAC
                                        {
                                            Console.Write("Asn ");
                                            i_7 = i_7 + 3;
                                        }

                                    }
                                    if (blobDNAarray[i_7 + 1] == 'T') //AT
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'C' | blobDNAarray[i_7 + 2] == 'T') //ATA & ATC & ATT
                                        {
                                            Console.Write("Ile ");
                                            i_7 = i_7 + 3;
                                        }
                                        if (blobDNAarray[i_7 + 2] == 'G') //ATG
                                        {
                                            Console.Write("Met ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                    if (blobDNAarray[i_7 + 1] == 'G') //AG
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G') //AGA & AGG
                                        {
                                            Console.Write("Arg ");
                                            i_7 = i_7 + 3;
                                        }
                                        if (blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //AGT & AGC
                                        {
                                            Console.Write("Ser ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                    if (blobDNAarray[i_7 + 1] == 'C') //AC
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G' | blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //ACT & ACC & ACA & ACG
                                        {
                                            Console.Write("Thr ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                }
                                if (blobDNAarray[i_7] == 'T') // starts with Thymin
                                {
                                    if (blobDNAarray[i_7 + 1] == 'A') //TA
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G') //TAA & TAG
                                        {
                                            Console.Write("END ");
                                            i_7 = i_7 + 3;
                                        }
                                        if (blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //TAT & TAC
                                        {
                                            Console.Write("Tyr ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                    if (blobDNAarray[i_7 + 1] == 'T') //TT
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G') //TTA & TTG
                                        {
                                            Console.Write("Leu ");
                                            i_7 = i_7 + 3;
                                        }
                                        if (blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //TTT & TTC
                                        {
                                            Console.Write("Phe ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                    if (blobDNAarray[i_7 + 1] == 'G') //TG
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //TGT & TGC
                                        {
                                            Console.Write("Cys ");
                                            i_7 = i_7 + 3;
                                        }
                                        if (blobDNAarray[i_7 + 2] == 'A') //TGA
                                        {
                                            Console.Write("END ");
                                            i_7 = i_7 + 3;
                                        }
                                        if (blobDNAarray[i_7 + 2] == 'G') //TGG
                                        {
                                            Console.Write("Trp ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                    if (blobDNAarray[i_7 + 1] == 'C') //TC
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G' | blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //TCA & TCG & TCT & TCC
                                        {
                                            Console.Write("Ser ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                }
                                if (blobDNAarray[i_7] == 'G') // starts with Guanine
                                {
                                    if (blobDNAarray[i_7 + 1] == 'A') //GA
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //GAT & GAC
                                        {
                                            Console.Write("Asp ");
                                            i_7 = i_7 + 3;
                                        }
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G') //GAA & GAG
                                        {
                                            Console.Write("Glu ");
                                            i_7 = i_7 + 3;
                                        }

                                    }
                                    if (blobDNAarray[i_7 + 1] == 'T') //GT
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G' | blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //GTA & GTG & GTT & GTC
                                        {
                                            Console.Write("Val ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                    if (blobDNAarray[i_7 + 1] == 'C') //GC
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G' | blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //GCA & GCG & GCT & GCC
                                        {
                                            Console.Write("Ala ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                    if (blobDNAarray[i_7 + 1] == 'G') //GG
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G' | blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //GGA & GGG & GGT & GGC
                                        {
                                            Console.Write("Gly ");
                                            i_7 = i_7 + 3;
                                        }
                                    }

                                }
                                if (blobDNAarray[i_7] == 'C') // starts with Cytosine
                                {
                                    if (blobDNAarray[i_7 + 1] == 'A') //CA
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //CAT & CAC
                                        {
                                            Console.Write("His ");
                                            i_7 = i_7 + 3;
                                        }
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G') //CAA & CAG
                                        {
                                            Console.Write("Gln ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                    if (blobDNAarray[i_7 + 1] == 'T') //CT
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G' | blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //CTA & CTG & CTT & CTC
                                        {
                                            Console.Write("Leu ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                    if (blobDNAarray[i_7 + 1] == 'G') //CG
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G' | blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //CGA & CGG & CGT & CGC
                                        {
                                            Console.Write("Arg ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                    if (blobDNAarray[i_7 + 1] == 'C') //CC
                                    {
                                        if (blobDNAarray[i_7 + 2] == 'A' | blobDNAarray[i_7 + 2] == 'G' | blobDNAarray[i_7 + 2] == 'T' | blobDNAarray[i_7 + 2] == 'C') //CCA & CCG & CCT & CCC
                                        {
                                            Console.Write("Pro ");
                                            i_7 = i_7 + 3;
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                        
                        OPnumber = 0;
                        Console.ReadLine();
                        break;
                    //##############################################################################################################################

                    
                    case 8://============================================= O P A R A T I O N 8 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 8 \n");

                        string[] DELETEcodons = new string[blobDNAarray.Length / 3];
                        int b = 0;
                        for (int i = 0; i < blobDNAarray.Length; i = i + 3)
                        {
                            DELETEcodons[b] = blobDNAarray[i].ToString() + blobDNAarray[i + 1].ToString() + blobDNAarray[i + 2].ToString();

                            b++;
                        }
                        Console.WriteLine("");
                        Console.Write("DNA strand (stage 1) : ");
                        for (int i = 0; i < DELETEcodons.Length; i++)
                        {

                            Console.Write(DELETEcodons[i] + " ");
                        }
                        Console.WriteLine("\nHow many codons do you want to delete?");
                        int codonNumber = Convert.ToInt32(Console.ReadLine()); //m
                        Console.WriteLine("Starting from ?");
                        int codonOrder = Convert.ToInt32(Console.ReadLine()); //n


                        char[] DELETEDcodons = new char[blobDNAarray.Length];


                        try 
                        {
                            int k = 0;
                            int z = 0;
                            for (int i = 0; i < blobDNAarray.Length; i++)
                            {
                                if (i == (codonOrder * 3 - 3) + k)
                                {
                                    while (k < codonNumber * 3)
                                    {
                                        k++;
                                        i++;
                                    }
                                }
                                DELETEDcodons[z] = blobDNAarray[i];
                                z++;
                            }
                        }
                        catch (Exception)
                        { 
                        }


                        string[] DELETEcodons_Show = new string[blobDNAarray.Length / 3];
                        int c_op8 = 0;
                        for (int i = 0; i < blobDNAarray.Length; i = i + 3)
                        {
                            DELETEcodons_Show[c_op8] = DELETEDcodons[i].ToString() + DELETEDcodons[i + 1].ToString() + DELETEDcodons[i + 2].ToString();
                            c_op8++;
                        }
                        blobDNAarray = DELETEDcodons;
                        Console.Write("DNA strand (stage 2) : ");
                        for (int i = 0; i < DELETEcodons.Length; i++)
                        {
                            Console.Write(DELETEcodons_Show[i] + " ");
                        }

                        OPnumber = 0;
                        Console.ReadLine();
                        break;
                    //##############################################################################################################################

                    
                    case 9://============================================= O P A R A T I O N 9 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 9 ");
                        //showing dna stage 1
                        Console.Write("\nDNA strand (stage 1) : ");
                        string[] OP9_Show = new string[blobDNAarray.Length / 3];
                        int op9i = 0;
                        for (int i = 0; i < blobDNAarray.Length; i = i + 3)
                        {
                            OP9_Show[op9i] = blobDNAarray[i].ToString() + blobDNAarray[i + 1].ToString() + blobDNAarray[i + 2].ToString();
                            op9i++;
                        }
                        for (int i = 0; i < OP9_Show.Length; i++)
                        {
                            Console.Write(OP9_Show[i] + " ");
                        }

                        // getting codon sequence

                        Console.Write("\nCodon sequence       : ");
                        string added = Convert.ToString(Console.ReadLine());
                        Console.Write("Starting from        : ");
                        int op9_counter = Convert.ToInt16(Console.ReadLine());

                        string addedUPPER = added.ToUpper();

                        char[] addedchars = addedUPPER.ToCharArray();              // making entered codons array



                        char[] op9_final = new char[addedchars.Length + blobDNAarray.Length];

                        Console.Write("DNA strand (stage 2) : ");


                        int y = 0;
                        try
                        {
                            for (int i = 0; i < op9_final.Length; i++)
                            {

                                if (i == op9_counter * 3 - 3)
                                {
                                    for (int k = 0; k < addedchars.Length; k++)
                                    {
                                        op9_final[i] = addedchars[k];
                                        i++;
                                    }
                                }

                                op9_final[i] = blobDNAarray[y];
                                y++;
                            }
                        }
                        catch (Exception)
                        {
                        }

                        string[] op9_Show2 = new string[op9_final.Length / 3];
                        int op9_show = 0;
                        for (int i = 0; i < op9_final.Length; i = i + 3)
                        {
                            op9_Show2[op9_show] = op9_final[i].ToString() + op9_final[i + 1].ToString() + op9_final[i + 2].ToString();

                            op9_show++;
                        }
                        for (int i = 0; i < op9_Show2.Length; i++)
                        {
                            Console.Write(op9_Show2[i] + " ");
                        }
                        blobDNAarray = op9_final;

                        OPnumber = 0;
                        Console.ReadLine();
                        break;
                    //##############################################################################################################################

                    
                    case 10://============================================= O P A R A T I O N 10 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 10 ");

                        Console.Write("Your DNA strand is : ");
                        for (int i = 0; i < blobDNAarray.Length; i++)
                        {
                            Console.Write(blobDNAarray[i]);
                        }

                        Console.WriteLine("\nPlease enter the codon sequence you want searched for");
                        string codon10 = Console.ReadLine();
                        codon10 = codon10.ToUpper();

                        Char[] codon10array = codon10.ToCharArray();
                        Console.WriteLine("Codon squence: " + codon10);
                        
                        Console.WriteLine("Which codon do you want it to be searched starting from");
                        int line_10 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Starting from: " + line_10);
                        
                        int linecount = line_10*3-3;
                        int counter_10 = 0;
                        
                        
                        try
                        {
                            for (int i = line_10 * 3 - 3; i < blobDNAarray.Length; i++)
                            {
                                if (codon10array[counter_10] == blobDNAarray[i])
                                {
                                    counter_10++;
                                    linecount++;
                                }
                                else
                                {
                                    counter_10 = 0;
                                    linecount++;
                                }
                                if (counter_10 == codon10array.Length)
                                {
                                    Console.WriteLine("The result is : " + ((linecount/3)-(codon10array.Length/3-1)));
                                }
                            }
                            if (counter_10 != codon10array.Length)
                            {
                                Console.WriteLine("The result is : -1");
                            }
                        }
                        catch (Exception)
                        {   
                        }
                        OPnumber = 0;
                        Console.ReadLine();

                        break;
                    //##############################################################################################################################


                    case 11://============================================= O P A R A T I O N 11 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 11 ");

                        Console.Write("Your DNA strand is : ");
                        for (int i = 0; i < blobDNAarray.Length; i++)
                        {
                            Console.Write(blobDNAarray[i]);
                        }

                        Console.WriteLine("\nStarting from which codon do you want it to be reversed?");
                        int reverse = (Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("\nHow many codons do you want to reverse?");
                        int reverse_11 = (Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Reverse " + reverse_11 + " codons, " + "starting from " + reverse + "th codon.");

                        int counter_11 = 0;
                        char[] h = new char[3];
                        int finalcodon = 3 * (reverse + reverse_11) - 4;
                        int firstcodon = 3 * reverse - 3;
                        for (int i = 1; i <= firstcodon; i++)
                        {
                            Console.Write(blobDNAarray[i - 1]);
                        }
                        for (int i = reverse_11; i >= 1; i--)
                        {
                            for (int j = finalcodon - 2; j <= finalcodon; j++)
                            {
                                h[counter_11] = blobDNAarray[j];
                                counter_11++;
                                for (int k = 0; k <= blobDNAarray.Length && k < h.Length; k++)
                                {
                                    Console.Write(h[k]);
                                    counter_11 = 0;
                                }
                            }
                            finalcodon -= 3;
                        }
                        finalcodon = 3 * (reverse + reverse_11) - 4;
                        for (int i = finalcodon + 2; i <= blobDNAarray.Length; i++)
                        {
                            Console.Write(blobDNAarray[i - 1]);
                        }
                        OPnumber = 0;
                        Console.ReadLine();

                        break;
                    //##############################################################################################################################


                    case 12://============================================= O P A R A T I O N 12 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 12 ");

                        Console.Write("Your DNA strand is : ");

                        for (int i = 0; i < blobDNAarray.Length; i++)
                        {
                            Console.Write(blobDNAarray[i]);
                        }

                        char[] ATGarray = { 'A', 'T', 'G' };
                        char[] TAAarray = { 'T', 'A', 'A' };
                        char[] TGAarray = { 'T', 'G', 'A' };
                        char[] TAGarray = { 'T', 'A', 'G' };
                        int controla = 0;
                        int controlb = 0;
                        int controlc = 0;
                        int controld = 0;



                        try
                        {
                            for (int i = 0; i < blobDNAarray.Length - 2; i++)
                            {

                                if (blobDNAarray[i] == 'A')
                                {
                                    if (blobDNAarray[i + 1] == 'T')
                                    {
                                        if (blobDNAarray[i + 2] == 'G')
                                        {
                                            controla++;
                                        }
                                    }
                                }

                            }

                            for (int i = 0; i < blobDNAarray.Length - 2; i++)
                            {

                                if (blobDNAarray[i] == 'T')
                                {
                                    if (blobDNAarray[i + 1] == 'A')
                                    {
                                        if (blobDNAarray[i + 2] == 'G')
                                        {
                                            controlb++;
                                        }
                                    }
                                }

                            }

                            for (int i = 0; i < blobDNAarray.Length - 2; i++)
                            {

                                if (blobDNAarray[i] == 'T')
                                {
                                    if (blobDNAarray[i + 1] == 'A')
                                    {
                                        if (blobDNAarray[i + 2] == 'A')
                                        {
                                            controlc++;
                                        }
                                    }
                                }

                            }

                            for (int i = 0; i < blobDNAarray.Length - 2; i++)
                            {

                                if (blobDNAarray[i] == 'T')
                                {
                                    if (blobDNAarray[i + 1] == 'G')
                                    {
                                        if (blobDNAarray[i + 2] == 'A')
                                        {
                                            controld++;
                                        }
                                    }
                                }

                            }
                        }
                        catch
                        {

                        }

                        if (controla == controlb || controla == controlc || controla == controld)
                        {
                            Console.WriteLine("\nNumbers of genes:" + controla);

                        }


                        OPnumber = 0;
                        Console.ReadLine();
                        break;
                    //##############################################################################################################################




                    case 13: //============================================= O P A R A T I O N 13 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 13 ");


                        char[] charDNAarray = new char[blobDNAarray.Length];
                        charDNAarray = blobDNAarray;
                        string[] Dnaa = new string[charDNAarray.Length / 3];
                        int iDnaa = 0; // for Counter of index of  Dnaa
                        for (int i = 0; i < charDNAarray.Length; i += 3)
                            Dnaa[iDnaa++] = charDNAarray[i].ToString() + charDNAarray[i + 1].ToString() + charDNAarray[i + 2].ToString();


                        int min = int.MaxValue; // for minimum number of codons in DNA
                        int counter = 0; // For number of codons in DNA
                        int c = 0; // for undrastan the limit of min DNA (for example from iDnaa=6 to iDnaa=10)
                        string[] MinDna = new string[100000];
                        int cMinDna = 0; // useful length of MinDna
                        int position = 0; // for position

                        iDnaa = 0;
                        while (iDnaa < Dnaa.Length)
                        {
                            if (Dnaa[iDnaa] == "ATG")
                            {
                                c = iDnaa;
                                counter = 1;
                                while (Dnaa[c] != "TGA" && Dnaa[c] != "TAG" && Dnaa[c] != "TAA")
                                {
                                    c++;
                                    counter++;
                                }

                                if (counter < min)
                                {
                                    min = counter;
                                    position = iDnaa;
                                    cMinDna = 0;
                                    for (int i = iDnaa; i < c + 1; i++)
                                        MinDna[cMinDna++] = Dnaa[i];
                                }
                            }
                            iDnaa++;
                        }// end of while


                        Console.Write("DNA strand    : ");
                        for (int i = 0; i < blobDNAarray.Length; i++)
                        {
                            Console.Write(blobDNAarray[i]);
                        }
                        Console.Write("\nShortest gene : ");
                        for (int i = 0; i < cMinDna; i++)
                            Console.Write(MinDna[i]);

                        Console.WriteLine();
                        Console.WriteLine("Number of codons in the gene : " + min);
                        Console.WriteLine("Position of the gene : " + (position + 1));


                        OPnumber = 0;
                        Console.ReadLine();

                        break;
                    
                    
                    case 14://============================================= O P A R A T I O N 14 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 14 ");


                        char[] charDNAarray_14 = new char[blobDNAarray.Length];
                        charDNAarray_14 = blobDNAarray;
                        string[] Dnaa_14 = new string[charDNAarray_14.Length / 3];
                        int iDnaa_14 = 0; // for Counter of index of  Dnaa
                        for (int i = 0; i < charDNAarray_14.Length; i += 3)
                            Dnaa_14[iDnaa_14++] = charDNAarray_14[i].ToString() + charDNAarray_14[i + 1].ToString() + charDNAarray_14[i + 2].ToString();

                        int max = 0; // for maximum number of codons in DNA
                        int counter_14 = 0; // For number of codons in DNA
                        int c_14 = 0; // for undrastan the limit of max DNA (for example from iDnaa=4 to iDnaa=12)
                        string[] MaxDna_14 = new string[100000];
                        int position_14 = 0; // for position
                        iDnaa_14 = 0;// counter of index of Dnaa
                        int cMaxDna = 0;
                        while (iDnaa_14 < Dnaa_14.Length)
                        {
                            if (Dnaa_14[iDnaa_14] == "ATG")
                            {
                                c_14 = iDnaa_14;
                                counter_14 = 1;
                                while (Dnaa_14[c_14] != "TGA" && Dnaa_14[c_14] != "TAG" && Dnaa_14[c_14] != "TAA")
                                {
                                    counter_14++;
                                    c_14++;
                                }
                                if (counter_14 > max)
                                {
                                    position_14 = iDnaa_14;
                                    max = counter_14;
                                    cMaxDna = 0;
                                    for (int i = iDnaa_14; i <= c_14; i++)
                                        MaxDna_14[cMaxDna++] = Dnaa_14[i];
                                }
                            }
                            iDnaa_14++;
                        }// end of while

                        Console.Write("DNA strand : ");
                        for (int i = 0; i < blobDNAarray.Length; i++)
                        {
                            Console.Write(blobDNAarray[i]);
                        }
                        Console.Write("\nLongest gene : ");
                        for (int i = 0; i < cMaxDna; i++)
                            Console.Write(MaxDna_14[i]);

                        Console.WriteLine();
                        Console.WriteLine("Number of codons in the gene : " + max);
                        Console.WriteLine("Position of the gene : " + (position_14 + 1));

                        
                        OPnumber = 0;
                        Console.ReadLine();

                        break;
                    
                    
                    case 15://============================================= O P A R A T I O N 15 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 15 ");

                        
                        char[] charDNAarray_15 = new char[blobDNAarray.Length];
                        charDNAarray_15 = blobDNAarray;
                        Console.Write("Enter number of nucletide :");
                        int icharDNAarray = 0;// counter of index of charDNAarray
                        int n = Convert.ToInt32(Console.ReadLine());
                        char[] Temp1 = new char[charDNAarray_15.Length];
                        char[] Temp2 = new char[charDNAarray_15.Length];
                        int iTemp = 0;
                        int flag_15 = 0;
                        int count = 0;
                        int max_15 = 0;
                        char[] Max = new char[n];
                        int iMax = 0;



                        while (icharDNAarray < charDNAarray_15.Length - n)
                        {

                            iTemp = 0;
                            int c_15 = icharDNAarray;
                            count = 0;
                            for (int j = c_15; j < n + c_15; j++)
                            {
                                Temp1[iTemp++] = charDNAarray_15[j];

                            }
                            c_15 = c_15 + n;
                            count++;
                            while (c_15 < charDNAarray_15.Length)
                            {
                                if (charDNAarray_15[c_15] == Temp1[0])
                                {
                                    iTemp = 0;

                                    for (int j = c_15; j < n + c_15 && j < charDNAarray_15.Length; j++)
                                    {
                                        Temp2[iTemp++] = charDNAarray_15[j];

                                    }
                                    flag_15 = 0;
                                    for (int i = 0; i < n; i++)
                                        if (Temp1[i] == Temp2[i])
                                            flag_15++;
                                    if (flag_15 == n)
                                    {
                                        c_15 = c_15 + n;
                                        count++;
                                    }
                                    else
                                        c_15++;



                                }
                                else
                                    c_15++;
                            }




                            if (count > max_15)
                            {
                                max_15 = count;
                                iMax = 0;
                                for (int i = icharDNAarray; i < n + icharDNAarray; i++)
                                    Max[iMax++] = charDNAarray_15[i];
                            }


                            icharDNAarray++;

                        }// end of whileeeee

                        Console.Write("Most repeated sequence :");
                        for (int i = 0; i < n; i++)
                            Console.Write(Max[i]);
                        Console.WriteLine();
                        Console.WriteLine("Frequency:" + max_15);

                        OPnumber = 0;
                        Console.ReadLine();

                        break;
                    
                    case 16://============================================= O P A R A T I O N 16 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 16 ");

                        char a = 'A';
                        char t = 'T';
                        char g = 'G';
                        char c_16 = 'C';

                        Console.WriteLine("-------------------------------------------------");

                        int counter16A = 0;
                        for (int i = 0; i < blobDNAarray.Length; i++)
                        {
                            if (a == blobDNAarray[i])
                            {
                                counter16A++;
                            }
                        }
                        Console.WriteLine("Amount of Adenine in this DNA is : " + counter16A);
                        int counter16T = 0;
                        for (int i = 0; i < blobDNAarray.Length; i++)
                        {
                            if (t == blobDNAarray[i])
                            {
                                counter16T++;
                            }
                        }
                        Console.WriteLine("Amount of Thymine in this DNA is : " + counter16T);
                        int counter16G = 0;
                        for (int i = 0; i < blobDNAarray.Length; i++)
                        {
                            if (g == blobDNAarray[i])
                            {
                                counter16G++;
                            }
                        }
                        Console.WriteLine("Amount of Guanine in this DNA is : " + counter16G);
                        int counter16C = 0;
                        for (int i = 0; i < blobDNAarray.Length; i++)
                        {
                            if (c_16 == blobDNAarray[i])
                            {
                                counter16C++;
                            }
                        }
                        Console.WriteLine("Amount of Cytosine in this DNA is : " + counter16C);

                        Console.WriteLine("-------------------------------------------------");

                        int twobonds = (counter16A + counter16T) * 2;
                        int threebonds = (counter16C + counter16G) * 3;
                        Console.WriteLine("Number of pairing with 2-hydrogen bonds: " + (counter16A + counter16T));
                        Console.WriteLine("Number of pairing with 3-hydrogen bonds: " + (counter16C + counter16G));
                        Console.WriteLine("Number of hydrogen bonds: " + (twobonds + threebonds));

                        OPnumber = 0;
                        Console.ReadLine();

                        break;
                    //##############################################################################################################################
                    case 17:
                        
                        
                        
                        break;
                }
            }
        }
    }
}
