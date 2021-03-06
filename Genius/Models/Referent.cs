﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Genius.Models
{
    /// <summary>
    ///     Referents are the sections of a piece of content to which annotations are attached.
    ///     https://docs.genius.com/#!#referents-h2
    /// </summary>
    public class Referent
    {
        [JsonProperty("_type")]
        public string Type { get; set; }

        public string AnnotatorId { get; set; }
        public string AnnotatorLogin { get; set; }
        public string ApiPath { get; set; }
        public string Classification { get; set; }
        public string Featured { get; set; }
        public string Fragment { get; set; }
        public string Id { get; set; }
        public bool? IsDescription { get; set; }
        public string Path { get; set; }
        public ReferentRange Range { get; set; }
        public string SongId { get; set; }
        public string Url { get; set; }
        public List<Annotation> Annotations { get; set; }
        public Annotatable Annotatable { get; set; }
        public List<string> VerifiedAnnotatorIds { get; set; }


        //Used in POST
        public string RawAnnotableUrl { get; set; }
        public ContextForDisplay ContextForDisplay { get; set; }
    }

    /// <summary>
    ///     Information for anchoring the referent in the source text
    /// </summary>
    public class ReferentRange
    {
        public string Start { get; set; }
    
        [JsonProperty("startoffset")]
        public string StartOffset { get; set; }
        
        public string End { get; set; }
        
        [JsonProperty("endoffset")]
        public string EndOffset { get; set; }
        
        public string Before { get; set; }
        public string After { get; set; }
        public string Content { get; set; }
    }

    public class ContextForDisplay
    {
        public string BeforeHtml { get; set; }
        public string AfterHtml { get; set; }
    }

    /// <summary>
    ///     Meta-data about the annotated document
    /// </summary>
    public class Annotatable
    {
        public string Api_Path { get; set; }
        public string Context { get; set; }
        public string Id { get; set; }
        public string Image_Url { get; set; }
        public string Link_Title { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
    }

    /// <summary>
    ///     Plural Referent Class
    /// </summary>
    public class Referents
    {
        public List<Referent> Referent { get; set; }
    }
}