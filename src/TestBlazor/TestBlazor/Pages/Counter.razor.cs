using TestBlazor.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace TestBlazor.Pages
{
    public partial class Counter
    {
        public string message { set; get; }
        int currentCount = 0;

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
    }
    
}