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
//----------------------------------------------------------------------------

module Freya.Types.Grammar

(* RFC 5234

   Core ABNF grammar rules as defined in RFC 5234, expressed
   as predicates over integer character codes.

   Taken from RFC 5234, Appendix B.1 Core Rules
   See [http://tools.ietf.org/html/rfc5234#appendix-B.1] *)

let alpha i =
        (i >= 0x41 && i <= 0x5a)
     || (i >= 0x61 && i <= 0x7a)

let digit i =
        (i >= 0x30 && i <= 0x39)

let dquote i =
        (i = 0x22)

let hexdig i =
        (digit i)
     || (i >= 0x41 && i <= 0x46)
     || (i >= 0x61 && i <= 0x66)

let htab i =
        (i = 0x09)

let sp i =
        (i = 0x20)

let vchar i =
        (i >= 0x21 && i <= 0x7e)

let wsp i =
        (htab i)
     || (sp i)