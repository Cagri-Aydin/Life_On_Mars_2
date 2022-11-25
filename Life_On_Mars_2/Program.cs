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
                        Console.WriteLine("Operation 11  ==>  Reverse codons ");                                                   //Progress: HAVE SOME PROBLEMS => İsra ÇEVİK
                        Console.WriteLine("Operation 12  ==>  Find the number of genes in a DNA strand (BLOB or not)");            //Progress: ON GOING           => İsra ÇEVİK
                        Console.WriteLine("Operation 13  ==>  Find the shortest gene in a DNA strand");                            //Progress: ON GOING           => İsra ÇEVİK
                        Console.WriteLine("Operation 14  ==>  Find the longest gene in a DNA strand");                             //Progress: ON GOING           => Eilyar RAZZAGHPOUR
                        Console.WriteLine("Operation 15  ==>  Find the most repeated n-nucleotide sequence in a DNA strand ");     //Progress: ON GOING           => Eilyar RAZZAGHPOUR
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


                        //gene structure ==> flag = 1, codon ==> flag = 2
                        int flag = 0;
                        int start_codon = 0;
                        int stop_codon = 0;
                        
                        
                        
                        string[] op4_Show = new string[blobDNAarray.Length / 3];
                        int op4_show = 0;
                        for (int i = 0; i < blobDNAarray.Length; i = i + 3)
                        {
                            op4_Show[op4_show] = blobDNAarray[i].ToString() + blobDNAarray[i + 1].ToString() + blobDNAarray[i + 2].ToString();

                            op4_show++;
                        }


                        /*if (flag == 0)
                        {
                            if (op4_Show[0] != "ATG" || (op4_Show[op4_Show.Length - 1] != "TAA" && op4_Show[op4_Show.Length - 1] != "TGA" && op4_Show[op4_Show.Length - 1] != "TAG"))
                                flag = 1;
                            for (int j = 0; j < op4_Show.Length - 1; j++)
                            {
                                if (op4_Show[j] == "ATG")
                                    start_codon = j;
                                else if (op4_Show[j] == "TAA" || op4_Show[j] == "TGA" || op4_Show[j] == "TAG")
                                {
                                    stop_codon = j;
                                    if (codon_num == 0)
                                        codon_num = stop_codon - start_codon;
                                    else
                                    {
                                        if (codon_num != stop_codon - start_codon)
                                        {
                                            flag = 1;
                                        }
                                    }
                                }
                            }
                          if (chars.Length % 3 != 0)
                                flag = 2;
                        }
                        else
                        {
                            if (chars.Length % 3 != 0)
                                flag = 2;
                        }

                        if (flag == 0)
                            Console.WriteLine("Gene structure is OK.");
                        else if (flag == 1)
                            Console.WriteLine("Gene structure error.");
                        else
                            Console.WriteLine("Codon structure error.");
                
                        //Operation 4


                
                        int first_codon = 0;
                        int last_codon = 0;
                        var gene, codon_num;
                        if (gene == 0)
                        {
                            if (op4_Show[0] != "ATG" || (op4_Show[op4_Show.Length - 1] != "TAA" && op4_Show[op4_Show.Length - 1] != "TGA" && op4_Show[op4_Show.Length - 1] != "TAG"))
                                gene = 1;
                            for (int j = 0; j < op4_Show.Length - 1; j++)
                            {
                                if (op4_Show[j] == "ATG")
                                    first_codon = j;
                                else if (op4_Show[j] == "TAA" || op4_Show[j] == "TGA" || op4_Show[j] == "TAG")
                                {
                                    last_codon = j;
                                    if (codon_num == 0)
                                        codon_num = last_codon - first_codon;
                                    else
                                    {
                                        if (codon_num != last_codon - first_codon)
                                        {
                                            gene = 1;
                                        }
                                    }
                                }
                            }
                            if (chars.Length % 3 != 0)
                                gene = 2;
                        }
                        else
                        {
                            if (chars.Length % 3 != 0)
                                gene = 2;
                        }

                        if (gene == 0)
                        {
                            Console.WriteLine("Gene structure is OK.");
                        }
                        else if (gene == 1)
                        {
                            Console.WriteLine("Gene structure error.");
                        }
                        else
                        {
                            Console.WriteLine("Codon structure error.");
                        }*/
                        

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
                        
                        if (blobDNAarray[0]=='A' & blobDNAarray[1] == 'T'& blobDNAarray[2] == 'G') //checking start codon
                        { 
                        }
                        else
                        {
                            Console.Write("Starting codon error. ");
                        }
                        if (blobDNAarray[3] == 'A' & blobDNAarray[4] == 'A' & blobDNAarray[5] == 'A' | blobDNAarray[3] == 'T' & blobDNAarray[4] == 'T' & blobDNAarray[5] == 'T' | blobDNAarray[3] == 'G' & blobDNAarray[4] == 'G' & blobDNAarray[5] == 'G' | blobDNAarray[3] == 'C' & blobDNAarray[4] == 'C' & blobDNAarray[5] == 'C') //checking first gender codon
                        {  
                        }
                        else
                        {
                            Console.Write("First gender codon error. ");
                        }
                        if (blobDNAarray[6] == 'A' & blobDNAarray[7] == 'C' & blobDNAarray[8] == 'A' | blobDNAarray[6] == 'T' & blobDNAarray[7] == 'T' & blobDNAarray[8] == 'T' | blobDNAarray[6] == 'G' & blobDNAarray[7] == 'G' & blobDNAarray[8] == 'G' | blobDNAarray[6] == 'C' & blobDNAarray[7] == 'C' & blobDNAarray[8] == 'C') //checking second gender codon
                        {  
                        }
                        else
                        {
                            Console.Write("Second gender codon error. ");
                        }
                        if (blobDNAarray[9] == 'T' & blobDNAarray[10] == 'A' & blobDNAarray[11] == 'G')
                        { 
                        }
                        else
                        {
                            Console.Write("Fourth codon error. ");
                        }
                        if (blobDNAarray[blobDNAarray.Length - 3] == 'T' & blobDNAarray[blobDNAarray.Length - 2] == 'G' & blobDNAarray[blobDNAarray.Length - 1] == 'A' & (blobDNAarray.Length / 3) - 4 >= 3)
                        {
                            Console.WriteLine("Blob is OK. ");
                        }
                        else
                        {
                            Console.WriteLine("Number of codons error. ");
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
                        try
                        {
                            int i = 0;
                            while (i < AAcodons.Length)
                            {
                                if (AAcodons[i] == "GCT" || AAcodons[i] == "GCC" || AAcodons[i] == "GCA" || AAcodons[i] == "GCG")
                                {
                                    Console.Write(aminoacids[0] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "CGT" || AAcodons[i] == "CGC" || AAcodons[i] == "CGA" || AAcodons[i] == "CGG" || AAcodons[i] == "AGA" || AAcodons[i] == "AGG")
                                {
                                    Console.Write(aminoacids[1] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "AAT" || AAcodons[i] == "AAC")
                                {
                                    Console.Write(aminoacids[2] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "GAT" || AAcodons[i] == "GAC")
                                {
                                    Console.Write(aminoacids[3] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "TGT" || AAcodons[i] == "TGC")
                                {
                                    Console.Write(aminoacids[4] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "CAA" || AAcodons[i] == "CAG")
                                {
                                    Console.Write(aminoacids[5] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "GAA" || AAcodons[i] == "GAG")
                                {
                                    Console.Write(aminoacids[6] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "GGT" || AAcodons[i] == "GGC" || AAcodons[i] == "GGA" || AAcodons[i] == "GGG")
                                {
                                    Console.Write(aminoacids[7] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "CAT" || AAcodons[i] == "CAC")
                                {
                                    Console.Write(aminoacids[8] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "AAT" || AAcodons[i] == "ATC" || AAcodons[i] == "ATA")
                                {
                                    Console.Write(aminoacids[9] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "CTT" || AAcodons[i] == "CTC" || AAcodons[i] == "CTA" || AAcodons[i] == "CTG" || AAcodons[i] == "TTA" || AAcodons[i] == "TTG")
                                {
                                    Console.Write(aminoacids[10] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "AAA" || AAcodons[i] == "AAG")
                                {
                                    Console.Write(aminoacids[11] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "ATG")
                                {
                                    Console.Write(aminoacids[12] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "TTT" || AAcodons[i] == "TTC")
                                {
                                    Console.Write(aminoacids[13] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "CCT" || AAcodons[i] == "CCC" || AAcodons[i] == "CCA" || AAcodons[i] == "CCG")
                                {
                                    Console.Write(aminoacids[14] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "TCT" || AAcodons[i] == "TCC" || AAcodons[i] == "TCA" || AAcodons[i] == "TCG" || AAcodons[i] == "AGT" || AAcodons[i] == "AGC")
                                {
                                    Console.Write(aminoacids[15] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "ACT" || AAcodons[i] == "ACC" || AAcodons[i] == "ACA" || AAcodons[i] == "ACG")
                                {
                                    Console.Write(aminoacids[16] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "TGG")
                                {
                                    Console.Write(aminoacids[17] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "TAT" || AAcodons[i] == "TAC")
                                {
                                    Console.Write(aminoacids[18] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "GTT" || AAcodons[i] == "GTC" || AAcodons[i] == "GTA" || AAcodons[i] == "GTG")
                                {
                                    Console.Write(aminoacids[19] + " ");
                                    i++;
                                }
                                if (AAcodons[i] == "TAA" || AAcodons[i] == "TGA" || AAcodons[i] == "TAG")
                                {
                                    Console.Write(aminoacids[20] + " ");
                                    i++;
                                }
                            }
                        }
                        catch (Exception)
                        {

                            Console.Write("");
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

                        int lineorder = 0;
                        int counter = 0;
                        for (int i = line_10*3-3; i < blobDNAarray.Length; i=blobDNAarray.Length)
                        {
                            try
                            {
                                if (codon10array[counter] == blobDNAarray[i])
                                {
                                    counter++;
                                    lineorder++;
                                }
                                else
                                {
                                    counter = 0;
                                    lineorder++;
                                }
                                if (counter == codon10array.Length)
                                {
                                    Console.WriteLine("The reslult is : " + lineorder / 3);
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("The result is : -1");
                                }
                            }
                            catch (Exception)
                            {
                                i = 1000000;    
                            }
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
                        
                        Console.WriteLine("\nHow many codons do you want to reverse?");
                        int reverse_11 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Starting from?");
                        int reverse = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Reverse " + reverse_11 + "codons, " + "starting from " + reverse + "th codon.");

                        if (reverse_11 % 2 == 1)
                        {
                            for (int i = (reverse - 1) * 3 + 1; i < ((reverse - 1) * 3 + 1) + ((reverse / 2) * 3); i = i++)
                            {
                                char temp = blobDNAarray[i];
                                blobDNAarray[i] = blobDNAarray[i + (reverse_11 * 3)];
                                blobDNAarray[i + (reverse_11 * 3)] = temp;
                            }
                            Console.WriteLine(blobDNAarray);
                        }

                        else if (reverse_11 % 2 == 0)
                        {
                            for (int i = (reverse - 1) * 3 + 1; i <= ((reverse - 1) * 3 + 1) + ((reverse / 2) * 3); i = i++)
                            {
                                char temp = blobDNAarray[i];
                                blobDNAarray[i] = blobDNAarray[i + (reverse_11 * 2)];
                                blobDNAarray[i + (reverse_11 * 2)] = temp;
                            }
                            Console.WriteLine(blobDNAarray);
                        }


                        break;
                    //##############################################################################################################################

                    
                    case 16://============================================= O P A R A T I O N 16 =====================================================
                        Console.Clear();
                        Console.WriteLine("==>  OPERATION 16 ");

                        char a = 'A';
                        char t = 'T';
                        char g = 'G';
                        char c = 'C';

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
                            if (c == blobDNAarray[i])
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
                }
            }
        }
    }
}
