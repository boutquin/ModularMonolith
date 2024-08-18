// Copyright (c) 2024 Pierre G. Boutquin. All rights reserved.
//
//   Licensed under the Apache License, Version 2.0 (the "License").
//   You may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
//   See the License for the specific language governing permissions and
//   limitations under the License.
//

namespace ModularMonolith.BookCatalog;

/// <summary>
/// Represents a Data Transfer Object (DTO) for a book.
/// </summary>
/// <param name="Id">The unique identifier of the book.</param>
/// <param name="Title">The title of the book.</param>
/// <param name="Author">The author of the book.</param>
public record BookDto(Guid Id, string Title, string Author);
