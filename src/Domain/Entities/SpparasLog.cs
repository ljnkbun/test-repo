using System;
using System.Collections.Generic;

namespace Infra;

public partial class SpparasLog
{
    public int ParameterId { get; set; }

    public string? StoreProcedureName { get; set; }

    public string? StoreProcedureParameterLog { get; set; }

    public DateTime? CreatedDateTime { get; set; }
}
