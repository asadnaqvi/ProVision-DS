using System;
class SequenceElements{
	static void Main(){
		//Driver_FindSequenceOfConsectiveEqualNumbers();
		//Driver_FindSequenceOfConsectiveIncreasingNumbers();
		//Driver_FindKNumbersWithMaxSum();
		//Driver_FindSubSequenceOfNumbersWithMaxSum();
		Driver_FindSubSequenceOfNumbersWithExactSum();
		System.Console.ReadLine();
	}
	//----------------------------------------------------------------------------------------------------------------------------------------
	//Write a program, which finds the maximal sequence of consecutive equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}.
	//----------------------------------------------------------------------------------------------------------------------------------------
	static void Driver_FindSequenceOfConsectiveEqualNumbers(){
		System.Console.WriteLine("Please Enter Size of Array - greater than 0");
		Int32 size = Int32.Parse(System.Console.ReadLine());
		if(size<=0)
			System.Console.WriteLine("Please Enter size greater than 0");
		Int32[] ary =  new Int32[size];
		for(Int32 i=0; i< size; i++){
			ary[i] = Int32.Parse(System.Console.ReadLine());
		}
		Int32[] ary2 = FindSequenceOfConsectiveEqualNumbers(ary);	
			for(Int32 i=0; i< ary2.Length; i++){
			System.Console.Write(ary2[i] + " , ");
		}
	}
	static Int32[] FindSequenceOfConsectiveEqualNumbers(Int32[] ary){
		if(ary==null) throw new Exception("Array Not Initialized");
		Int32 count=1,location=0,sequence=0,bestCount=1,bestSequence=0;
		for(Int32 i=0;i<ary.Length; i++){
			if(ary[i]!=sequence){						
				if(count > bestCount ){
					bestCount = count;
					bestSequence=sequence;
				}
				sequence = ary[i];
				location=i;	
				count=1;
			}else{
				count = count + 1;
			}
		}
		if(count > bestCount ){
					bestCount = count;
					bestSequence=sequence;
		}
		System.Console.WriteLine("sequence = " + bestSequence + " | Count = " + bestCount);
		Int32[] ary2 = new Int32[bestCount];
		for(Int32 i=0; i < ary2.Length; i++){
			ary2[i]= bestSequence;
		}
		return ary2;
	}
	//----------------------------------------------------------------------------------------------------------------------------------------
	//Write a program, which finds the maximal sequence of consecutively placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
	//----------------------------------------------------------------------------------------------------------------------------------------
	static void Driver_FindSequenceOfConsectiveIncreasingNumbers(){
		System.Console.WriteLine("Please Enter Size of Array - greater than 0");
		Int32 size = Int32.Parse(System.Console.ReadLine());
		if(size<=0)
			System.Console.WriteLine("Please Enter size greater than 0");
		Int32[] ary =  new Int32[size];
		for(Int32 i=0; i< size; i++){
			ary[i] = Int32.Parse(System.Console.ReadLine());
		}
		Int32[] ary2 = FindSequenceOfConsectiveIncreasingNumbers(ary);	
			for(Int32 i=0; i< ary2.Length; i++){
			System.Console.Write(ary2[i] + " , ");
		}
	}
	static Int32[] FindSequenceOfConsectiveIncreasingNumbers(Int32[] ary){
		if(ary==null) throw new Exception("Array Not Initialized");
		Int32 count=1,startIndex=0,sequence=ary[0],bestCount=1,bestStartIndex=0;
		for(Int32 i=1;i<ary.Length; i++){
			if(ary[i]<=sequence){						
				if(count > bestCount ){
					bestCount = count;
					bestStartIndex=startIndex;
				}				
				startIndex=i;	
				count=1;
			}else{
				count = count + 1;
			}
			sequence = ary[i];
		}
		if(count > bestCount ){
					bestCount = count;
					bestStartIndex=startIndex;
		}
		System.Console.WriteLine("start index = " + bestStartIndex + " | length = " + bestCount);
		Int32[] ary2 = new Int32[bestCount];
		for(Int32 i=0; i < ary2.Length; i++){
			ary2[i]= ary[bestStartIndex];
			bestStartIndex ++;
		}
		return ary2;
	}
	//--------------------------------------
	//Write a program, which reads from the console two integer numbers N and K (K<N) and array of N integers. Find those K consecutive elements in the array, which have maximal sum.
	//--------------------------------------
	static void Driver_FindKNumbersWithMaxSum(){
		System.Console.WriteLine("Please Enter Size of Array - greater than 0");
		Int32 size = Int32.Parse(System.Console.ReadLine());
		if(size<=0)
			System.Console.WriteLine("Please Enter size greater than 0");
		Int32[] ary =  new Int32[size];
		for(Int32 i=0; i< size; i++){
			ary[i] = Int32.Parse(System.Console.ReadLine());
		}
		System.Console.WriteLine("Please Enter K where K<N :");
		Int32 k = Int32.Parse(System.Console.ReadLine());
		Int32[] ary2 = FindKNumbersWithMaxSum(ary,k);	
			for(Int32 i=0; i< ary2.Length; i++){
			System.Console.Write(ary2[i] + " , ");
		}
	}
	static Int32[] FindKNumbersWithMaxSum(Int32[] ary,Int32 k){
		Int32 startIndex=0,sum=0;
		for(Int32 i=0; i < k ; i++){
			sum = sum + ary[i];
		}
		for(Int32 i=k; i< ary.Length; i++){
			Int32 runningSum = sum + ary[i] - ary[i-k];
			if(sum< runningSum){
				sum = runningSum;
				startIndex = i-k+1;
			}
		}
		Int32[] ary2 = new Int32[k];
		for(Int32 i=0; i < k ; i++){
			ary2[i] = ary[startIndex];
			startIndex++;
		}
		return ary2;
	}
	//-----------------------
	//Write a program, which finds a subsequence of numbers with maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11
	//-----------------------
	static void Driver_FindSubSequenceOfNumbersWithMaxSum(){
		System.Console.WriteLine("Please Enter Size of Array - greater than 0");
		Int32 size = Int32.Parse(System.Console.ReadLine());
		if(size<=0)
			System.Console.WriteLine("Please Enter size greater than 0");
		Int32[] ary =  new Int32[size];
		for(Int32 i=0; i< size; i++){
			ary[i] = Int32.Parse(System.Console.ReadLine());
		}		
		Int32[] ary2 = FindSubSequenceOfNumbersWithMaxSum(ary);	
			for(Int32 i=0; i< ary2.Length; i++){
			System.Console.Write(ary2[i] + " , ");
		}
	}
	static Int32[] FindSubSequenceOfNumbersWithMaxSum(Int32[] ary)
        {
            Int32 startIdex = 0, endIndex = 0, sum = 0, maxSum = 0,maxStartIndex=0,maxEndIndex=0;
            for (Int32 i = 0; i < ary.Length; i++)
            {
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxStartIndex = startIdex;
                    maxEndIndex = endIndex;
                }
                sum = ary[i];
                for (Int32 j = i + 1; j < ary.Length; j++)
                {
                    if (sum < sum + ary[j])
                    {
                        startIdex = i;
                        endIndex = j;
                    }
                    sum = sum + ary[j];
                }

            }
            Int32 count = maxEndIndex - maxStartIndex + 1;
            Int32[] ary2 = new Int32[count];
            for (Int32 i = 0; i < count; i++)
            {
                ary2[i] = ary[maxStartIndex + i];
            }
            return ary2;
        }
			//--------------------------------------
	//Write a program to find a sequence of neighbor numbers in an array, which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}.
	//--------------------------------------
	static void Driver_FindSubSequenceOfNumbersWithExactSum(){
		System.Console.WriteLine("Please Enter Size of Array - greater than 0");
		Int32 size = Int32.Parse(System.Console.ReadLine());
		if(size<=0)
			System.Console.WriteLine("Please Enter size greater than 0");
		Int32[] ary =  new Int32[size];
		for(Int32 i=0; i< size; i++){
			ary[i] = Int32.Parse(System.Console.ReadLine());
		}
		System.Console.WriteLine("Please Enter Total:");
		Int32 total = Int32.Parse(System.Console.ReadLine());
		Int32[] ary2 = FindSubSequenceOfNumbersWithExactSum(ary,total);	
			for(Int32 i=0; i< ary2.Length; i++){
			System.Console.Write(ary2[i] + " , ");
		}
	}
		static Int32[] FindSubSequenceOfNumbersWithExactSum(Int32[] ary,Int32 total){
			Int32 sum=0,startIndex=0,endIndex=0;
			Boolean found = false;
			for(Int32 i=0; i<ary.Length; i++){
				sum=ary[i];
				for(Int32 j=i+1; j<ary.Length; j++){
					if(sum + ary[j] == total){
						found = true;
						startIndex = i;
						endIndex = j;
					}
					sum = sum + ary[j];
					if(sum + ary[j] > total) break;
				}
			}
			Int32 count = 0;
			if(found==true){
				count = endIndex - startIndex + 1;
			}			
			Int32[] ary2 = new Int32[count];
			for (Int32 i=0;i<count;i++){
				ary2[i] = ary[startIndex + i];
			}
			return ary2;
		}
}