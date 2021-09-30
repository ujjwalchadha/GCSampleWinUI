#pragma once
#include "HierarchyA.g.h"

namespace winrt::test_component_base::implementation
{
    struct HierarchyA : HierarchyAT<HierarchyA>
    {
        HierarchyA() = default;

        HierarchyA(hstring const& name);
        virtual winrt::hstring HierarchyA_Method();
        Windows::Foundation::Collections::IVector<Windows::Foundation::IInspectable> GetList();
        Windows::Foundation::Collections::IObservableVector<Windows::Foundation::IInspectable> GetXamlList();
    };
}
namespace winrt::test_component_base::factory_implementation
{
    struct HierarchyA : HierarchyAT<HierarchyA, implementation::HierarchyA>
    {
    };
}
