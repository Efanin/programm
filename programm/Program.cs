using programm.LinQ;

double[] arr = new double[10].Select(x=>new Random().NextDouble()).ToArray().Print().Where(x=>x%2==0).ToArray().Print(); 