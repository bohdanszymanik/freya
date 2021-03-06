﻿//----------------------------------------------------------------------------
//
// Copyright (c) 2014
//
//    Ryan Riley (@panesofglass) and Andrew Cherry (@kolektiv)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//----------------------------------------------------------------------------

[<AutoOpen>]
module Freya.Lenses.Http.Cors.Lenses

open Aether.Operators
open Arachne.Http.Cors
open Freya.Lenses.Http

(* Request Lenses *)

[<RequireQualifiedAccess>]
module Request =

    (* Request Header Lenses *)

    [<RequireQualifiedAccess>]
    module Headers =

        let private header_ key tryParse format =
            Request.Header_ key <??> (tryParse, format)

        let AccessControlRequestHeaders_ =
            header_ "Access-Control-Request-Headers" AccessControlRequestHeaders.TryParse AccessControlRequestHeaders.Format

        let AccessControlRequestMethod_ =
            header_ "Access-Control-Request-Method" AccessControlRequestMethod.TryParse AccessControlRequestMethod.Format

        let Origin_ =
            header_ "Origin" Origin.TryParse Origin.Format

(* Response Lenses *)

[<RequireQualifiedAccess>]
module Response =

    (* Response Header Lenses *)

    [<RequireQualifiedAccess>]
    module Headers =

        let private header_ key tryParse format =
            Response.Header_ key <??> (tryParse, format)

        let AccessControlAllowCredentials_ =
            header_ "Access-Control-Allow-Credentials" AccessControlAllowCredentials.TryParse AccessControlAllowCredentials.Format

        let AccessControlAllowHeaders_ =
            header_ "Access-Control-Allow-Headers" AccessControlAllowHeaders.TryParse AccessControlAllowHeaders.Format

        let AccessControlAllowMethods_ =
            header_ "Access-Control-Allow-Methods" AccessControlAllowMethods.TryParse AccessControlAllowMethods.Format

        let AccessControlAllowOrigin_ =
            header_ "Access-Control-Allow-Origin" AccessControlAllowOrigin.TryParse AccessControlAllowOrigin.Format

        let AccessControlExposeHeaders_ =
            header_ "Access-Control-Expose-Headers" AccessControlExposeHeaders.TryParse AccessControlExposeHeaders.Format

        let AccessControlMaxAge_ =
            header_ "Access-Control-Max-Age" AccessControlMaxAge.TryParse AccessControlMaxAge.Format