public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        var amino = new List<string>();
        for(int i=0; i<=strand.Length-3;i+=3)
        {
            var condon = strand.Substring(i,3);
            var protien = condon switch{
                    "AUG"=>"Methionine",
                    "UUU" or "UUC"=>"Phenylalanine",
                    "UUA" or "UUG" =>"Leucine",
                    "UCU" or "UCC" or "UCA" or "UCG"=> "Serine",
                    "UAU" or "UAC" => "Tyrosine",
                    "UGU" or "UGC" => "Cysteine",
                    "UGG" => "Tryptophan",
                    "UAA" or "UAG" or "UGA" => null,
                    _ => throw new ArgumentException("Invalid Argument")
            };
            if(protien==null)
            {
                break;
            } 
            amino.Add(protien);
        }
        return amino.ToArray();
    }
}

