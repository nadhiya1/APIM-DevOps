﻿using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Abstractions;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Extractor.Models;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Extractor.EntityExtractors.Abstractions
{
    public interface IApiExtractor
    {
        Task<JToken[]> GetAllApiObjsAsync(string apiManagementName, string resourceGroupName);

        Task<List<string>> GetAllApiNamesAsync(string apiManagementName, string resourceGroupName);

        Task<string> GetServiceDiagnosticsAsync(string apiManagementName, string resourceGroupName);

        Task<string> GetApiDiagnosticsAsync(string apiManagementName, string resourceGroupName, string apiName);

        Task<Template> GenerateAPIsARMTemplateAsync(ExtractorParameters extractorParameters, string singleApiName, List<string> multipleApiNames, string baseFilesGenerationDirectory);

        Task<string> GetAPIRevisionsAsync(string apiManagementName, string resourceGroupName, string apiName);

        Task<Template> GenerateAPIRevisionTemplateAsync(ExtractorParameters extractorParameters, string currentRevision, List<string> revList, string baseFilesGenerationDirectory);
    }
}