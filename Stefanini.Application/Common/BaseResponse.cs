using System;
using System.Collections.Generic;
using System.Text;

namespace Stefanini.Application.Common
{
    public abstract class BaseResponse
    {
        public bool Success { get; set; } = true;

        public object? Error { get; set; } = null;
    }
}
