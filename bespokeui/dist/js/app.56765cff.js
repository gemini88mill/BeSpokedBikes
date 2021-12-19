(function(t){function e(e){for(var a,r,i=e[0],c=e[1],l=e[2],d=0,p=[];d<i.length;d++)r=i[d],Object.prototype.hasOwnProperty.call(o,r)&&o[r]&&p.push(o[r][0]),o[r]=0;for(a in c)Object.prototype.hasOwnProperty.call(c,a)&&(t[a]=c[a]);u&&u(e);while(p.length)p.shift()();return n.push.apply(n,l||[]),s()}function s(){for(var t,e=0;e<n.length;e++){for(var s=n[e],a=!0,i=1;i<s.length;i++){var c=s[i];0!==o[c]&&(a=!1)}a&&(n.splice(e--,1),t=r(r.s=s[0]))}return t}var a={},o={app:0},n=[];function r(e){if(a[e])return a[e].exports;var s=a[e]={i:e,l:!1,exports:{}};return t[e].call(s.exports,s,s.exports,r),s.l=!0,s.exports}r.m=t,r.c=a,r.d=function(t,e,s){r.o(t,e)||Object.defineProperty(t,e,{enumerable:!0,get:s})},r.r=function(t){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(t,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(t,"__esModule",{value:!0})},r.t=function(t,e){if(1&e&&(t=r(t)),8&e)return t;if(4&e&&"object"===typeof t&&t&&t.__esModule)return t;var s=Object.create(null);if(r.r(s),Object.defineProperty(s,"default",{enumerable:!0,value:t}),2&e&&"string"!=typeof t)for(var a in t)r.d(s,a,function(e){return t[e]}.bind(null,a));return s},r.n=function(t){var e=t&&t.__esModule?function(){return t["default"]}:function(){return t};return r.d(e,"a",e),e},r.o=function(t,e){return Object.prototype.hasOwnProperty.call(t,e)},r.p="/";var i=window["webpackJsonp"]=window["webpackJsonp"]||[],c=i.push.bind(i);i.push=e,i=i.slice();for(var l=0;l<i.length;l++)e(i[l]);var u=c;n.push([0,"chunk-vendors"]),s()})({0:function(t,e,s){t.exports=s("56d7")},"026f":function(t,e,s){},"034f":function(t,e,s){"use strict";s("85ec")},2871:function(t,e,s){"use strict";s("026f")},"56d7":function(t,e,s){"use strict";s.r(e);s("e260"),s("e6cf"),s("cca6"),s("a79d");var a=s("2b0e"),o=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{attrs:{id:"app"}},[s("div",{staticClass:"container"},[s("div",{staticClass:"row"},[t._m(0),s("div",{staticClass:"col"},[s("div",{staticClass:"btn-group"},[s("button",{staticClass:"btn btn-primary",on:{click:function(e){t.view="report"}}},[t._v("Reports")]),s("button",{staticClass:"btn btn-primary",on:{click:function(e){t.view="products"}}},[t._v("Products")]),s("button",{staticClass:"btn btn-primary",on:{click:function(e){t.view="customer"}}},[t._v("Customer")]),s("button",{staticClass:"btn btn-primary",on:{click:function(e){t.view="sales-people"}}},[t._v("Sales")]),s("button",{staticClass:"btn btn-primary",on:{click:function(e){t.view="sales"}}},[t._v("History")])])])]),s("div",{staticClass:"row"},[s("transition",{attrs:{name:"component-fade",mode:"out-in"}},[s(t.view,{tag:"component",attrs:{"sales-people":t.users},on:{update:t.updateSalesPeople}})],1)],1)])])},n=[function(){var t=this,e=t.$createElement,a=t._self._c||e;return a("div",{staticClass:"col"},[a("div",{},[a("img",{attrs:{src:s("c14a"),alt:"logo.png"}}),a("h4",[t._v("BeSpoked Bikes")])])])}],r=s("bc3a"),i=s.n(r),c=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"container-fluid"},[t._m(0),t._m(1),t._l(t.salesPeople,(function(e){return s("div",{key:e.index,staticClass:"row mb-3"},[s("sales-person",{attrs:{"sales-person":e},on:{saleEvent:t.createSale,update:t.updateSalesPeople}})],1)})),s("div",{directives:[{name:"show",rawName:"v-show",value:!0===t.createSaleView,expression:"createSaleView === true"}],staticClass:"row"},[s("create-sale",{attrs:{"sales-person-id":t.salesPerson}})],1)],2)},l=[function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"row"},[s("div",{staticClass:"col text-start"},[s("h5",[t._v("Sales People")])])])},function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"row border-bottom mb-3"},[s("div",{staticClass:"col text-muted"},[t._v("Name")]),s("div",{staticClass:"col text-muted"},[t._v("Manager")]),s("div",{staticClass:"col text-muted"})])}],u=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"container"},[t.editMode?s("div",{staticClass:"row"},[s("div",{staticClass:"col-4 mb-3"},[s("input",{directives:[{name:"model",rawName:"v-model",value:t.salesPersonAdd.name,expression:"salesPersonAdd.name"}],staticClass:"form-control",attrs:{type:"text"},domProps:{value:t.salesPersonAdd.name},on:{input:function(e){e.target.composing||t.$set(t.salesPersonAdd,"name",e.target.value)}}})]),s("div",{staticClass:"col-4 mb-3"},[s("input",{directives:[{name:"model",rawName:"v-model",value:t.salesPersonAdd.manager,expression:"salesPersonAdd.manager"}],staticClass:"form-control",attrs:{type:"text"},domProps:{value:t.salesPersonAdd.manager},on:{input:function(e){e.target.composing||t.$set(t.salesPersonAdd,"manager",e.target.value)}}})]),s("div",{staticClass:"col-4 mb-3"},[s("div",{staticClass:"btn-group"},[s("button",{staticClass:"btn btn-primary",attrs:{type:"button"},on:{click:function(e){return t.saveData()}}},[t._v("Save")]),s("button",{staticClass:"btn btn-danger",attrs:{type:"button"},on:{click:function(e){t.editMode=!t.editMode}}},[t._v("Delete")])])]),s("div",{staticClass:"col text-start"},[s("label",[t._v("Address")]),s("input",{directives:[{name:"model",rawName:"v-model",value:t.salesPersonAdd.address,expression:"salesPersonAdd.address"}],staticClass:"form-control",attrs:{type:"text"},domProps:{value:t.salesPersonAdd.address},on:{input:function(e){e.target.composing||t.$set(t.salesPersonAdd,"address",e.target.value)}}})]),s("div",{staticClass:"col text-start"},[s("label",[t._v("Phone")]),s("input",{directives:[{name:"model",rawName:"v-model",value:t.salesPersonAdd.phone,expression:"salesPersonAdd.phone"}],staticClass:"form-control",attrs:{type:"text"},domProps:{value:t.salesPersonAdd.phone},on:{input:function(e){e.target.composing||t.$set(t.salesPersonAdd,"phone",e.target.value)}}})])]):s("div",{staticClass:"row",class:t.checkTerm},[s("div",{staticClass:"col"},[s("p",[t._v(t._s(t.salesPerson.name))])]),s("div",{staticClass:"col"},[s("p",[t._v(t._s(t.salesPerson.manager))])]),s("div",{staticClass:"col"},[s("div",{staticClass:"btn-group"},[s("button",{staticClass:"btn btn-warning",attrs:{type:"button"},on:{click:function(e){t.editMode=!t.editMode}}},[t._v("Edit")]),s("button",{staticClass:"btn btn-success",attrs:{type:"button",disabled:t.isInvalidUser},on:{click:function(e){return t.addSale()}}},[t._v("Sale")])])])])])},d=[],p=(s("a9e3"),s("b0c0"),s("e9c4"),s("ac1f"),s("1276"),{name:"SalesPerson",props:{salesPerson:{name:String,manager:String,phone:String,salesPersonId:Number,address:String,startDate:Date,endDate:Date},editModePar:Boolean},data:function(){return{editMode:this.editModePar,salesPersonAdd:{name:this.salesPerson.name,address:this.salesPerson.address,phone:this.salesPerson.phone,manager:this.salesPerson.manager}}},methods:{addSale:function(){this.$emit("saleEvent",this.salesPerson.salesPersonId)},saveData:function(){var t=this;this.editMode=!this.editMode;var e=this.splitName(this.salesPersonAdd.name),s={salesPersonId:this.salesPerson.salesPersonId,firstName:e[0],lastName:e.length>1?e[e.length-1]:"",address:this.salesPersonAdd.address,phone:this.salesPersonAdd.phone,manager:this.salesPersonAdd.manager};i()({method:"post",url:this.$hostname+"salesperson/update",headers:{"Access-Control-Allow-Origin":"*","Content-type":"application/json"},data:JSON.stringify(s)}).then((function(e){alert(e.data.response),t.$emit("update",!0)})).catch((function(e){console.log(e),alert(e.response.data.response),t.salesPersonAdd={name:t.salesPerson.name,address:t.salesPerson.address,phone:t.salesPerson.phone,manager:t.salesPerson.manager}}))},splitName:function(t){return t.split(" ")}},computed:{checkTerm:function(){return this.salesPerson.endDate<Date.now||this.salesPerson.startDate>Date.now?{"text-muted":!0}:{}},isInvalidUser:function(){return this.salesPerson.endDate<Date.now||this.salesPerson.startDate>Date.now}}}),m=p,v=s("2877"),f=Object(v["a"])(m,u,d,!1,null,"7c679d28",null),h=f.exports,_=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"container-fluid"},[s("div",{staticClass:"row mb-3"},[s("div",{staticClass:"col"},[s("label",[t._v("Customer")]),s("select",{directives:[{name:"model",rawName:"v-model",value:t.customerSelected,expression:"customerSelected"}],staticClass:"form-select",on:{change:function(e){var s=Array.prototype.filter.call(e.target.options,(function(t){return t.selected})).map((function(t){var e="_value"in t?t._value:t.value;return e}));t.customerSelected=e.target.multiple?s:s[0]}}},t._l(t.customers,(function(e){return s("option",{key:e.index,domProps:{value:e.customerId}},[t._v(t._s(e.name))])})),0)]),s("div",{staticClass:"col"},[s("label",[t._v("Product")]),s("select",{directives:[{name:"model",rawName:"v-model",value:t.productSelected,expression:"productSelected"}],staticClass:"form-select",on:{change:function(e){var s=Array.prototype.filter.call(e.target.options,(function(t){return t.selected})).map((function(t){var e="_value"in t?t._value:t.value;return e}));t.productSelected=e.target.multiple?s:s[0]}}},t._l(t.products,(function(e){return s("option",{key:e.index,domProps:{value:e.productId}},[t._v(" "+t._s(e.manufacturer)+" "+t._s(e.name))])})),0)]),void 0!==t.currentProductPrice?s("div",{staticClass:"col"},[s("div",{staticClass:"row-cols-1"},[t._v("Sale Price")]),s("div",{staticClass:"row-cols-1"},[t._v(" $"+t._s(t.formatDecimals(t.salePrice))+" ")])]):s("div",{staticClass:"col"}),s("div",{staticClass:"col"},[s("button",{staticClass:"btn btn-primary",on:{click:function(e){return t.submitSale()}}},[t._v("Submit")])])]),s("div",{staticClass:"row"},[s("h5",[t._v("Discounts")]),t._m(0),t._l(t.applicableDiscounts,(function(e){return s("div",{key:e.index},[s("discount-item",{attrs:{discount:e},on:{discount:t.applyDiscounts}})],1)}))],2)])},C=[function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"row mb-3 border-bottom"},[s("div",{staticClass:"col"},[t._v("Name")]),s("div",{staticClass:"col"},[t._v("Discount Applied")]),s("div",{staticClass:"col"})])}],b=(s("7db0"),s("d3b7"),s("4de4"),s("b680"),function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"container-fluid"},[s("div",{staticClass:"row"},[s("div",{staticClass:"col",class:t.discountHl},[t._v(t._s(t.discount.discountName))]),s("div",{staticClass:"col",class:t.discountHl},[t._v(t._s(t.discount.discountPct))]),s("div",{staticClass:"col"},[s("button",{staticClass:"btn btn-primary",attrs:{disabled:!t.isDiscountValid},on:{click:t.applyDiscount}},[t._v("Apply")])])])])}),g=[],P={name:"discountItem",data:function(){return{disabledClassObj:{"text-muted":!0},isDiscountValid:!1}},props:{discount:Object},methods:{applyDiscount:function(){this.$emit("discount",this.discount.discountPct),this.isDiscountValid=!1}},mounted:function(){Date.now()>=new Date(this.discount.beginDate)&&Date.now()<=new Date(this.discount.endDate)&&(this.isDiscountValid=!0)},computed:{discountHl:function(){return this.discountIsValid?{"fw-bold":!0}:{"text-muted":!0}},discountIsValid:function(){return Date.now()>=new Date(this.discount.beginDate)&&Date.now()<=new Date(this.discount.endDate)}}},y=P,w=Object(v["a"])(y,b,g,!1,null,"4ee0bd6a",null),x=w.exports,S={name:"CreateSale",components:{DiscountItem:x},props:{salesPersonId:Number,salesPersonName:String},data:function(){return{customers:[],products:[],productSelected:0,customerSelected:0,discounts:[],discountApplied:0}},mounted:function(){var t=this;i()({method:"get",url:this.$hostname+"customer",headers:{"Access-Control-Allow-Origin":"*"}}).then((function(e){return t.customers=e.data})).catch((function(t){return console.log(t)})),i()({method:"get",url:this.$hostname+"products",headers:{"Access-Control-Allow-Origin":"*"}}).then((function(e){return t.products=e.data})).catch((function(t){return console.log(t)})),i()({method:"get",url:this.$hostname+"discount",headers:{"Access-Control-Allow-Origin":"*"}}).then((function(e){return t.discounts=e.data})).catch((function(t){return console.log(t)}))},computed:{currentProductPrice:function(){var t=this;return this.products.find((function(e){return e.productId===t.productSelected}))},applicableDiscounts:function(){var t=this;return this.discounts.filter((function(e){return e.productId===t.productSelected}))},salePrice:function(){return 0===this.discountApplied?this.currentProductPrice.salePrice:this.currentProductPrice.salePrice-this.currentProductPrice.salePrice*(this.discountApplied/100)}},methods:{formatDecimals:function(t){return t.toFixed(2)},applyDiscounts:function(t){if(void 0===t)return 0;this.discountApplied=t},submitSale:function(){var t=this,e={salesPersonId:this.salesPersonId,customerId:this.customerSelected,productId:this.productSelected};console.log(e),i()({method:"post",url:this.$hostname+"sales/newsale",headers:{"Access-Control-Allow-Origin":"*","Content-type":"application/json"},data:JSON.stringify(e)}).then((function(e){t.products=e.data,alert("Success sale added")})).catch((function(t){alert("something went wrong, please see console for details"),console.log(t)}))}}},A=S,D=Object(v["a"])(A,_,C,!1,null,"e52bfb6c",null),$=D.exports,M={name:"SalesPeople",components:{CreateSale:$,SalesPerson:h},props:{salesPeople:Array},data:function(){return{createSaleView:!1,salesPerson:null}},methods:{createSale:function(t){this.createSaleView=!0,this.salesPerson=t},updateSalesPeople:function(){this.$emit("update",!0)}}},O=M,N=Object(v["a"])(O,c,l,!1,null,"239ebcf5",null),k=N.exports,I=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"container-fluid"},[s("div",{staticClass:"row d-flex justify-content-center mb-3"},[s("div",{staticClass:"col"},[s("div",{staticClass:"form-group"},[s("label",[t._v("Quarter")]),s("input",{directives:[{name:"model",rawName:"v-model.number",value:t.qtr,expression:"qtr",modifiers:{number:!0}}],staticClass:"form-control",attrs:{type:"number",max:"4",min:"1"},domProps:{value:t.qtr},on:{input:function(e){e.target.composing||(t.qtr=t._n(e.target.value))},blur:function(e){return t.$forceUpdate()}}})])]),s("div",{staticClass:"col"},[s("label",[t._v("Year")]),s("input",{directives:[{name:"model",rawName:"v-model.number",value:t.year,expression:"year",modifiers:{number:!0}}],staticClass:"form-control",attrs:{type:"number",max:(new Date).getFullYear(),min:(new Date).getFullYear()-20},domProps:{value:t.year},on:{input:function(e){e.target.composing||(t.year=t._n(e.target.value))},blur:function(e){return t.$forceUpdate()}}})]),s("div",{staticClass:"col"},[s("label",[t._v("Sales Person")]),s("select",{directives:[{name:"model",rawName:"v-model",value:t.salespersonId,expression:"salespersonId"}],staticClass:"form-select",on:{change:function(e){var s=Array.prototype.filter.call(e.target.options,(function(t){return t.selected})).map((function(t){var e="_value"in t?t._value:t.value;return e}));t.salespersonId=e.target.multiple?s:s[0]}}},[s("option",{domProps:{value:null}}),t._l(t.salesPeople,(function(e){return s("option",{key:e.index,domProps:{value:e.salesPersonId}},[t._v(t._s(e.name))])}))],2)]),s("div",{staticClass:"col"},[s("div",{staticClass:"btn-group"},[s("button",{staticClass:"btn btn-primary btn-group",attrs:{type:"button"},on:{click:function(e){return t.getReport()}}},[t._v("Go")])])])]),s("div",{staticClass:"row"},[t.results.length>0?s("report-results",{attrs:{results:t.results}}):t._e()],1)])},j=[],E=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"container-fluid"},[t._m(0),t._l(t.results,(function(e){return s("div",{key:e.index,staticClass:"row"},[s("div",{staticClass:"col"},[t._v(t._s(e.salesPersonName))]),s("div",{staticClass:"col"},[t._v(t._s(e.salesCount))]),s("div",{staticClass:"col text-end"},[t._v("$"+t._s(t.formatDecimals(e.commissionTotal)))]),s("div",{staticClass:"col text-end"},[t._v("$"+t._s(t.formatDecimals(e.totalSales)))])])}))],2)},q=[function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"row text-muted border-bottom"},[s("div",{staticClass:"col "},[t._v("Name")]),s("div",{staticClass:"col"},[t._v("Number of Sales")]),s("div",{staticClass:"col"},[t._v("Commission Total")]),s("div",{staticClass:"col"},[t._v("Total Sales")])])}],H={name:"reportResults",props:{results:Array},methods:{formatDecimals:function(t){return t.toFixed(2)}}},V=H,T=Object(v["a"])(V,E,q,!1,null,"7ee175fa",null),R=T.exports,F={name:"report",components:{ReportResults:R},props:{salesPeople:Array},data:function(){return{qtr:1,year:(new Date).getFullYear(),salespersonId:null,results:[]}},methods:{getReport:function(){var t=this;i()({method:"post",url:this.$hostname+"reports",headers:{"Access-Control-Allow-Origin":"*","Content-type":"application/json"},data:JSON.stringify({qtr:this.qtr,year:this.year,salespersonId:this.salespersonId})}).then((function(e){return t.results=e.data})).catch((function(t){return alert("something went wrong, please see console for details. "+t)}))}}},J=F,U=Object(v["a"])(J,I,j,!1,null,"3fe5c434",null),Y=U.exports,B=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"container-fluid"},[t._m(0),s("transition-group",{staticClass:"sales",attrs:{name:"flip-list",tag:"div"}},t._l(t.sales,(function(e,a){return s("div",{key:a,staticClass:"row sales"},[s("div",{staticClass:"col"},[t._v(t._s(e.productName))]),s("div",{staticClass:"col"},[t._v(t._s(e.customerName))]),s("div",{staticClass:"col"},[t._v(t._s(e.saleDate))]),s("div",{staticClass:"col"},[t._v("$"+t._s(t.formatDecimals(e.price)))]),s("div",{staticClass:"col"},[t._v(t._s(e.salesPersonName))]),s("div",{staticClass:"col"},[t._v("$"+t._s(t.formatDecimals(e.commission)))])])})),0),s("button",{staticClass:"btn btn-primary",attrs:{type:"button"},on:{click:t.sort}},[t._v("Sort by Date")])],1)},Q=[function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"row mb-3 border-bottom"},[s("div",{staticClass:"col"},[t._v("Product")]),s("div",{staticClass:"col"},[t._v("Customer")]),s("div",{staticClass:"col"},[t._v("Date")]),s("div",{staticClass:"col"},[t._v("Price")]),s("div",{staticClass:"col"},[t._v("Salesperson")]),s("div",{staticClass:"col"},[t._v("Commission")])])}],G=(s("4e82"),{name:"Sales",data:function(){return{sales:[]}},mounted:function(){var t=this;i()({method:"get",url:this.$hostname+"sales",headers:{"Access-Control-Allow-Origin":"*"}}).then((function(e){return t.sales=e.data})).catch((function(t){return console.log(t)}))},methods:{formatDecimals:function(t){return t.toFixed(2)},sort:function(){this.sales=this.sales.sort((function(t,e){return t.saleDate>e.saleDate?1:-1}))}}}),z=G,K=(s("2871"),Object(v["a"])(z,B,Q,!1,null,"e462c466",null)),L=K.exports,W=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"container-fluid"},[t._m(0),t._m(1),t._l(t.products,(function(e){return s("div",{key:e.index,staticClass:"row mb-3"},[s("product-item",{attrs:{product:e},on:{update:t.refresh}})],1)}))],2)},X=[function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"row"},[s("div",{staticClass:"col"},[s("h4",[t._v("Products")])])])},function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"row mb-3 border-bottom"},[s("div",{staticClass:"col"},[t._v("Manufacturer")]),s("div",{staticClass:"col"},[t._v("Item Name")]),s("div",{staticClass:"col"},[t._v("Style")]),s("div",{staticClass:"col"},[t._v("Purchase Price")]),s("div",{staticClass:"col"},[t._v("Sale Price")]),s("div",{staticClass:"col"},[t._v("Quantity on Hand")]),s("div",{staticClass:"col"})])}],Z=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"container"},[t.editMode?s("div",{staticClass:"row"},[s("div",{staticClass:"col"},[s("input",{directives:[{name:"model",rawName:"v-model",value:t.productModel.manufacturer,expression:"productModel.manufacturer"}],staticClass:"form-control form-text",attrs:{type:"text"},domProps:{value:t.productModel.manufacturer},on:{input:function(e){e.target.composing||t.$set(t.productModel,"manufacturer",e.target.value)}}})]),s("div",{staticClass:"col"},[s("input",{directives:[{name:"model",rawName:"v-model",value:t.productModel.name,expression:"productModel.name"}],staticClass:"form-control form-text",attrs:{type:"text"},domProps:{value:t.productModel.name},on:{input:function(e){e.target.composing||t.$set(t.productModel,"name",e.target.value)}}})]),s("div",{staticClass:"col"},[s("input",{directives:[{name:"model",rawName:"v-model",value:t.productModel.style,expression:"productModel.style"}],staticClass:"form-control form-text",attrs:{type:"text"},domProps:{value:t.productModel.style},on:{input:function(e){e.target.composing||t.$set(t.productModel,"style",e.target.value)}}})]),s("div",{staticClass:"col"},[s("input",{directives:[{name:"model",rawName:"v-model",value:t.productModel.purchasePrice,expression:"productModel.purchasePrice"}],staticClass:"form-control form-text",attrs:{type:"number",step:"0.01"},domProps:{value:t.productModel.purchasePrice},on:{input:function(e){e.target.composing||t.$set(t.productModel,"purchasePrice",e.target.value)}}})]),s("div",{staticClass:"col"},[s("input",{directives:[{name:"model",rawName:"v-model",value:t.productModel.salePrice,expression:"productModel.salePrice"}],staticClass:"form-control form-text",attrs:{type:"number",step:"0.01"},domProps:{value:t.productModel.salePrice},on:{input:function(e){e.target.composing||t.$set(t.productModel,"salePrice",e.target.value)}}})]),s("div",{staticClass:"col"},[s("input",{directives:[{name:"model",rawName:"v-model",value:t.productModel.qtyOnHand,expression:"productModel.qtyOnHand"}],staticClass:"form-control form-text",attrs:{type:"number"},domProps:{value:t.productModel.qtyOnHand},on:{input:function(e){e.target.composing||t.$set(t.productModel,"qtyOnHand",e.target.value)}}})]),s("div",{staticClass:"col"},[s("button",{staticClass:"btn btn-success",on:{click:t.updateProducts}},[t._v("Save")])])]):s("div",{staticClass:"row"},[s("div",{staticClass:"col"},[t._v(t._s(t.product.manufacturer))]),s("div",{staticClass:"col"},[t._v(t._s(t.product.name))]),s("div",{staticClass:"col"},[t._v(t._s(t.product.style))]),s("div",{staticClass:"col"},[t._v(t._s(t.product.purchasePrice))]),s("div",{staticClass:"col"},[t._v(t._s(t.product.salePrice))]),s("div",{staticClass:"col"},[t._v(t._s(t.product.qtyOnHand))]),s("div",{staticClass:"col"},[s("button",{staticClass:"btn btn-primary",on:{click:function(e){t.editMode=!t.editMode}}},[t._v("Update")])])])])},tt=[],et={name:"productItem",props:{product:Object},data:function(){return{editMode:!1,productModel:{manufacturer:this.product.manufacturer,name:this.product.name,commissionPct:this.product.commissionPct,purchasePrice:this.product.purchasePrice,qtyOnHand:this.product.qtyOnHand,salePrice:this.product.salePrice,style:this.product.style,productId:this.product.productId}}},methods:{updateProducts:function(){var t=this;this.editMode=!this.editMode;var e=this.productModel;i()({method:"post",url:this.$hostname+"products/update",headers:{"Access-Control-Allow-Origin":"*","Content-type":"application/json"},data:JSON.stringify(e)}).then((function(e){console.log(e.data),alert("Success"),t.$emit("update",!0)})).catch((function(t){return alert(t.response.data.response)}))}}},st=et,at=Object(v["a"])(st,Z,tt,!1,null,"6327c4cc",null),ot=at.exports,nt={name:"products",components:{ProductItem:ot},data:function(){return{products:[]}},methods:{refresh:function(){this.getProducts()},getProducts:function(){var t=this;i()({method:"get",url:this.$hostname+"products",headers:{"Access-Control-Allow-Origin":"*"}}).then((function(e){return t.products=e.data})).catch((function(t){return console.log(t)}))}},mounted:function(){this.getProducts()}},rt=nt,it=Object(v["a"])(rt,W,X,!1,null,"4d560457",null),ct=it.exports,lt=function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"container-fluid"},[t._m(0),t._l(t.customers,(function(e){return s("div",{key:e.index,staticClass:"row"},[s("div",{staticClass:"col"},[t._v(t._s(e.name))]),s("div",{staticClass:"col"},[t._v(t._s(e.address))]),s("div",{staticClass:"col"},[t._v(t._s(e.phone))])])}))],2)},ut=[function(){var t=this,e=t.$createElement,s=t._self._c||e;return s("div",{staticClass:"row mb-3 border-bottom text-muted"},[s("div",{staticClass:"col"},[t._v("Name")]),s("div",{staticClass:"col"},[t._v("Address")]),s("div",{staticClass:"col"},[t._v("Phone Number")])])}],dt={name:"customer",data:function(){return{customers:[]}},mounted:function(){var t=this;i()({method:"get",url:this.$hostname+"customer",headers:{"Access-Control-Allow-Origin":"*"}}).then((function(e){return t.customers=e.data})).catch((function(t){return console.log(t)}))}},pt=dt,mt=Object(v["a"])(pt,lt,ut,!1,null,"93d485a2",null),vt=mt.exports,ft={name:"App",components:{Report:Y,SalesPeople:k,Sales:L,Products:ct,customer:vt},data:function(){return{users:[],view:"sales-people"}},mounted:function(){var t=this;i()({method:"get",url:this.$hostname+"salesperson",headers:{"Access-Control-Allow-Origin":"*"}}).then((function(e){return t.users=e.data})).catch((function(t){return console.log(t)}))},methods:{updateSalesPeople:function(){var t=this;i()({method:"get",url:this.$hostname+"salesperson",headers:{"Access-Control-Allow-Origin":"*"}}).then((function(e){return t.users=e.data})).catch((function(t){return console.log(t)}))}}},ht=ft,_t=(s("034f"),Object(v["a"])(ht,o,n,!1,null,null,null)),Ct=_t.exports;s("ab8b"),s("7b17");a["a"].config.productionTip=!1,a["a"].prototype.$hostname="https://localhost:5001/",new a["a"]({render:function(t){return t(Ct)}}).$mount("#app")},"85ec":function(t,e,s){},c14a:function(t,e,s){t.exports=s.p+"img/bespokedlogo.30b3b396.png"}});
//# sourceMappingURL=app.56765cff.js.map