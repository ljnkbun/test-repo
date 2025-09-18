using System;
using System.Collections.Generic;

namespace Infra;

public partial class SurveysSurveyTargetAudienceDetail
{
    public int Id { get; set; }

    public int TenantId { get; set; }

    public int? SurveyTargetAudienceId { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? ZaloChatId { get; set; }

    public string? Email { get; set; }

    public string? FacebookId { get; set; }

    public string? MemberCode { get; set; }

    public string? CommunicationLanguage { get; set; }

    public string? CommunicationChannel { get; set; }

    public string? OutletCode { get; set; }
}
