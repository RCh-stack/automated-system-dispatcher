#pragma checksum "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00ff93bfc5f03c063daa1fd7df4dae864079a871"
// <auto-generated/>
#pragma warning disable 1591
namespace SystemDispatcher.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using SystemDispatcher;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using SystemDispatcher.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/Cars")]
    public partial class Cars : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Car list</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "width:750px");
            __Blazor.SystemDispatcher.Pages.Cars.TypeInference.CreateSfGrid_0(__builder, 3, 4, 
#nullable restore
#line 14 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                         cars

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 14 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                                            true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 15 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                       new List<string>() { "Add", "Edit", "Update", "Delete", "Cancel" }

#line default
#line hidden
#nullable disable
            , 7, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(8);
                __builder2.AddAttribute(9, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.EditMode>(
#nullable restore
#line 16 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                                EditMode.Dialog

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(14);
                __builder2.AddAttribute(15, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                                    5

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<CarModel>>(17);
                __builder2.AddAttribute(18, "OnActionBegin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.ActionEventArgs<CarModel>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.ActionEventArgs<CarModel>>(this, 
#nullable restore
#line 19 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                                   ActionBeginHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(20);
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(22);
                    __builder3.AddAttribute(23, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                               nameof(newCar.Fullname)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "HeaderText", "Driver");
                    __builder3.AddAttribute(25, "Width", "40px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(27);
                    __builder3.AddAttribute(28, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                               nameof(newCar.Brand)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "HeaderText", "Brand");
                    __builder3.AddAttribute(30, "Width", "40px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(32);
                    __builder3.AddAttribute(33, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                               nameof(newCar.Speed)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "HeaderText", "Speed");
                    __builder3.AddAttribute(35, "Width", "40px");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(37);
                    __builder3.AddAttribute(38, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
                               nameof(newCar.Capacity)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "HeaderText", "Capacity");
                    __builder3.AddAttribute(40, "Width", "40px");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\benja\Desktop\Command project\SystemDispatcher\SystemDispatcher\Pages\Cars.razor"
       

    private List<CarModel> cars;
    private CarModel newCar = new CarModel();

    protected override async Task OnInitializedAsync()
    {
        toastService.ShowInfo("Use the Add, Edit, Delete buttons to add, edit and delete entries.");
        cars = await _db.GetCar();
    }

    public async void ActionBeginHandler(ActionEventArgs<CarModel> Args)
    {
        if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Save))
        {
            if (Args.Action == "Add")
            {
                await _db.InsertCar(Args.Data);

                cars.Add(Args.Data);

                newCar = new CarModel();

                toastService.ShowSuccess("Post added successfully, please refresh the page..");
            }
            else
            {
                await _db.UpdateCar(Args.Data);
                toastService.ShowSuccess("The record has been successfully modified, please refresh the page.");
            }
        }

        if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Delete))
        {
            await _db.DeleteCar(Args.Data);
            toastService.ShowSuccess("Post deleted successfully, please refresh the page.");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICarData _db { get; set; }
    }
}
namespace __Blazor.SystemDispatcher.Pages.Cars
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "Toolbar", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
