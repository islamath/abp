﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.CmsKit.Contents;

namespace Volo.CmsKit.Public.Contents
{
    
    [RemoteService(Name = CmsKitCommonRemoteServiceConsts.RemoteServiceName)]
    [Area("cms-kit")]
    [Route("api/cms-kit-public/contents")]
    public class ContentController : CmsKitControllerBase, IContentPublicAppService
    {
        protected readonly IContentPublicAppService _contentAppService;

        public ContentController(IContentPublicAppService contentAppService)
        {
            _contentAppService = contentAppService;
        }

        [HttpGet]
        public virtual Task<ContentDto> GetAsync(GetContentInput input)
        {
            return _contentAppService.GetAsync(input);
        }
    }
}
