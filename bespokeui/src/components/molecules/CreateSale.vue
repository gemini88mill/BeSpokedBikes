<template>
  <div class="container-fluid">
    <div class="row mb-3">
      <div class="col">
        <label>Customer</label>
        <select class="form-select" v-model="customerSelected">
          <option v-for="item in customers" :key="item.index" :value="item.customerId">{{ item.name }}</option>
        </select>
      </div>
      <div class="col">
        <label>Product</label>
        <select class="form-select" v-model="productSelected">
          <option v-for="item in products" :key="item.index" :value="item.productId"> {{ item.manufacturer }} {{ item.name }}</option>
        </select>
      </div>
      <div class="col" v-if="currentProductPrice !== undefined">
        <div class="row-cols-1">Sale Price</div>
        <div class="row-cols-1">
          ${{ formatDecimals(salePrice) }}
        </div>
      </div>
      <div class="col" v-else></div>
      <div class="col">
        <button class="btn btn-primary" @click="submitSale()">Submit</button>
      </div>
    </div>
    <div class="row">
      <h5>Discounts</h5>
      <div class="row mb-3 border-bottom">
        <div class="col">Name</div>
        <div class="col">Discount Applied</div>
        <div class="col"></div>
      </div>
      <div v-for="item in applicableDiscounts" :key="item.index">
        <discount-item :discount="item" @discount="applyDiscounts"></discount-item>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";
import DiscountItem from "@/components/atoms/discountItem";

export default {
  name: "CreateSale",
  components: {DiscountItem},
  props: {
    salesPersonId: Number,
    salesPersonName: String
  },
  data: function (){
    return {
      customers: [],
      products: [],
      productSelected: 0,
      customerSelected: 0,
      discounts: [],
      discountApplied: 0
    }
  },
  mounted() {
    axios({
      method: 'get',
      url: this.$hostname + 'customer',
      headers: {
        'Access-Control-Allow-Origin': '*'
      }
    }).then(response => this.customers = response.data)
        .catch(err => console.log(err))

    axios({
      method: 'get',
      url: this.$hostname + 'products',
      headers: {
        'Access-Control-Allow-Origin': '*'
      }
    }).then(response => this.products = response.data)
        .catch(err => console.log(err));

    axios({
      method: 'get',
      url: this.$hostname + 'discount',
      headers: {
        'Access-Control-Allow-Origin': '*'
      }
    }).then(response => this.discounts = response.data)
        .catch(err => console.log(err));
  },
  computed: {
    currentProductPrice: function () {
      return this.products.find(obj => obj.productId === this.productSelected);
    },
    applicableDiscounts: function(){
      return this.discounts.filter(obj => obj.productId === this.productSelected);
    },
    salePrice: function(){
      if(this.discountApplied === 0){
        return this.currentProductPrice.salePrice
      }

      return this.currentProductPrice.salePrice - this.currentProductPrice.salePrice * ((this.discountApplied / 100))
    }
  },
  methods: {
    formatDecimals: function(val){
      return val.toFixed(2)
    },
    applyDiscounts: function(val){
      if(val === undefined){
        return 0;
      }

      this.discountApplied = val;
    },
    submitSale: function(){
      let payload = {
        salesPersonId: this.salesPersonId,
        customerId: this.customerSelected,
        productId: this.productSelected,
        salePrice: this.salePrice,
        commissionAwarded: this.salePrice * (this.currentProductPrice.commissionPct / 100)
      }

      console.log(payload);

      axios({
        method: 'post',
        url: this.$hostname + 'sales/newsale',
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-type': 'application/json'
        },
        data: JSON.stringify(payload)
      }).then(response => {
        this.products = response.data
        alert("Success sale added");
      }).catch(err => {
        alert("something went wrong, please see console for details");
        console.log(err);
      })
    }
  },

}
</script>

<style scoped>

</style>