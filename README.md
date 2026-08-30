[![](https://img.shields.io/nuget/v/soenneker.quark.enums.columnalignments.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.columnalignments/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.columnalignments/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.columnalignments/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.columnalignments/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.columnalignments/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.columnalignments.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.columnalignments/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.columnalignments/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.columnalignments/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.ColumnAlignments

Strongly named cross-axis self-alignment values for grid and flex children.

## Installation

```bash
dotnet add package Soenneker.Quark.Enums.ColumnAlignments
```

## Usage

```csharp
using Soenneker.Quark;

ColumnAlignmentType alignment = ColumnAlignmentType.Center;
string value = alignment.Value;
// center

string tailwindClass = $"self-{alignment.Value}";
// self-center
```

| Value | `.Value` | Tailwind utility |
| --- | --- | --- |
| `Start` | `start` | `self-start` |
| `Center` | `center` | `self-center` |
| `End` | `end` | `self-end` |
| `Stretch` | `stretch` | `self-stretch` |
| `Baseline` | `baseline` | `self-baseline` |

The stored value is the alignment suffix, not the full Tailwind class. This makes the type usable in component logic as well as utility-class composition.
