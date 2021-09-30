#include "pch.h"
#include "HierarchyA.h"
#include "HierarchyA.g.cpp"

namespace winrt
{
    template <typename T, typename Allocator = std::allocator<T>>
    Windows::Foundation::Collections::IVectorView<T> single_threaded_vector_view(std::vector<T, Allocator>&& values = {})
    {
        return make<impl::input_vector_view<T, std::vector<T, Allocator>>>(std::move(values));
    }

}

namespace winrt::test_component_base::implementation
{
    HierarchyA::HierarchyA(hstring const& name)
    {
        throw hresult_not_implemented();
    }
    winrt::hstring HierarchyA::HierarchyA_Method()
    {
        return L"HierarchyA.HierarchyA_Method";
    }
    Windows::Foundation::Collections::IVector<Windows::Foundation::IInspectable> HierarchyA::GetList()
    {
        Windows::Foundation::Collections::IVector<Windows::Foundation::IInspectable> vec{ winrt::single_threaded_vector<Windows::Foundation::IInspectable>() };
        for (auto i = 0; i < 1000; i++)
        {
            vec.Append(winrt::box_value(100));
        }
        return vec;
    }
    Windows::Foundation::Collections::IObservableVector<Windows::Foundation::IInspectable> test_component_base::implementation::HierarchyA::GetXamlList()
    {
        Windows::Foundation::Collections::IObservableVector<Windows::Foundation::IInspectable> vec{ winrt::single_threaded_observable_vector<Windows::Foundation::IInspectable>() };
        for (auto i = 0; i < 1000; i++)
        {
            vec.Append(winrt::box_value(100));
        }
        return vec;
    }
}
