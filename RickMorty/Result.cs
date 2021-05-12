using RickMorty.Mortys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickMorty
{
    public enum ResultType { NewExit, GetItem,GetMorty,MessageOnly}
    public class Result
    {
        public ResultType Type { get; }
        public string ResultExit { get; }
        public Item ResultItem { get; }
        public IMorty ResultMorty { get; }
        public string ResultMessage { get; }
        public string ResultDestination { get; }

        public Result(string resultExit, string resultMessage)
        {
            this.Type = ResultType.NewExit;
            this.ResultExit = resultExit;
            this.ResultMessage = resultMessage;
        }

        public Result(Item resultItem, string resultMessage)
        {
            this.Type = ResultType.GetItem;
            this.ResultItem = resultItem;
            this.ResultMessage = resultMessage;
        }

        public Result(IMorty resultMorty , string resultMessage)
        {
            this.Type = ResultType.GetMorty;
            this.ResultMorty = resultMorty;
            this.ResultMessage = resultMessage;
        }
        public Result(string resultMessage)
        {
            this.Type = ResultType.MessageOnly;
            this.ResultMessage = resultMessage;
        }
    }
}
