using TestBlazor.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace TestBlazor.Pages
{
    public partial class Counter
    {
        [Parameter]
        public int newcount { get; set; }
        public string message { set; get; }
        [Parameter]
        public int currentCount {set;get;} = 0;
protected override async Task OnInitializedAsync()
    {
        currentCount+=newcount;
        //var data = new List<int>{1,2,3,4,5,6,7};
        //Cetak<int>(data);
    }
        void IncrementCount()
        {
            currentCount++;
            message = $"<div class='alert alert-info'>{currentCount}</div>";
        }
        [JSInvokable]
        public static Task<string> ReturnData()
        {
            return Task.FromResult("Hello say...");
        }

        void Cetak<T>(List<T> Data){
            foreach(var item in Data)
                Console.WriteLine(item);
        }
    }
    
}