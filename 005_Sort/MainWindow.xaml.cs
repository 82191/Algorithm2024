using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _005_Sort
{
  public partial class MainWindow : Window
  {
    static int MAX = 1000000;
    int[] a = new int[MAX];
    int N = 0;
    Random r = new Random();

    public MainWindow()
    {
      InitializeComponent();
    }

    private void btnRandom_Click(object sender, RoutedEventArgs e)
    {
      txtResult.Text = "";
      N = int.Parse(txtData.Text);
      txtBubble.Text = "버블 정렬 : ";
      txtQuick.Text = "퀵 정렬 : ";
      txtMerge.Text = "합병 정렬 : ";
      Randomize();
      PrintData("랜덤 숫자");
    }

    private void Randomize()
    {      
      for (int i = 0; i < N; i++)
        a[i] = r.Next(5 * N);
    }

    private void PrintData(string s)
    {
      txtResult.Text += "\n" + s + "\n";
      for (int i = 0; i < N; i++)
      {
        txtResult.Text += a[i] + " ";
      }
      txtResult.Text += "\n";
    }

    private void btnTime_Click(object sender, RoutedEventArgs e)
    {
      var watch = System.Diagnostics.Stopwatch.StartNew();
      BubbleSort();      
      watch.Stop();
      PrintData("버블 정렬");
      long tickBubble = watch.ElapsedTicks;
      long msBubble = watch.ElapsedMilliseconds;
      txtBubble.Text = "버블 정렬 : " + tickBubble + " Ticks, " + msBubble + " ms";

      Randomize();
      watch = System.Diagnostics.Stopwatch.StartNew();
      QuickSort(a, 0, N-1);      
      watch.Stop();
      PrintData("퀵 정렬");
      long tickQuick = watch.ElapsedTicks;
      long msQuick = watch.ElapsedMilliseconds;
      txtQuick.Text = "퀵 정렬 : " + tickQuick + " Ticks, " + msQuick + " ms";

      Randomize();
      watch = System.Diagnostics.Stopwatch.StartNew();
      MergeSort(a, 0, N - 1);      
      watch.Stop();
      PrintData("합병 정렬");
      long tickMerge = watch.ElapsedTicks;
      long msMerge = watch.ElapsedMilliseconds;
      txtMerge.Text = "합병 정렬 : " + tickMerge + " Ticks, " + msMerge + " ms";
    }

    private void MergeSort(int[] a, int left, int right)
    {
            int i, j, k = left, l;
            static int sortes[MAX_SIZE];

            for int(i = left, j = mid + 1; j <= mid && j <= right;) { 
                sorted[k++] = (List[i] <= List[j]) ? List[i++] : list[j++];
                if(i > mid)
                    for (l=j; l<=mid; l++, k++)
                        sorted[k] = List[l];
                else
                    for(l=i; l<=mid; l++, k++)
                        sorted[k] = List[l];
                for(l=left; l<=right; l++)
                    List[l] = sorted[l];
            }
    }

        void merge_sort (int list[], int left, int right)
        {
            if(left < right) {
                int mid = (left + right) / 2;
                merge_sort(list, left, mid);
                merge_sort(list, left, mid);
                merge_sort(list, mid + 1, right);
                merge_sort(list , left, mid, right);
            }
        }

        private void QuickSort(int[] a, int left, int right)
        {
            int q;
            if(left < right) {
                q = Partitioner(List, left, right);
                quick_sort(List, left, q - 1);
                quick_sort(List, q+1, right);
            }
        
        }

        int partition (int list[], int left, int right)
        {
            int tmp;
            int low = left + 1;
            int high = right;
            int pivot = list[left];

            while(low < high) {
                for ( ; low <= right && list[low] < pivot; low++);
                for ( ; high >= left && list[high] > pivot; high--);
                if (low < high)
                    SWAP(list[low], list[high], tmp);
            }
        }

    private void BubbleSort()
    {
    
    }
  }
}
