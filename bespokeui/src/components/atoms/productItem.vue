<template>
  <div class="container">
    <div class="row" v-if="!editMode">
      <div class="col">{{product.manufacturer}}</div>
      <div class="col">{{product.name}}</div>
      <div class="col">{{product.style}}</div>
      <div class="col">{{product.purchasePrice}}</div>
      <div class="col">{{product.salePrice}}</div>
      <div class="col">{{product.qtyOnHand}}</div>
      <div class="col">
        <button class="btn btn-primary" @click="editMode = !editMode">Update</button>
      </div>
    </div>
    <div class="row" v-else>
      <div class="col">
        <input type="text" class="form-control form-text" v-model="productModel.manufacturer">
      </div>
      <div class="col">
        <input type="text" class="form-control form-text" v-model="productModel.name">
      </div>
      <div class="col">
        <input type="text" class="form-control form-text" v-model="productModel.style">
      </div>
      <div class="col">
        <input type="number" step="0.01" class="form-control form-text" v-model="productModel.purchasePrice">
      </div>
      <div class="col">
        <input type="number" step="0.01" class="form-control form-text" v-model="productModel.salePrice">
      </div>
      <div class="col">
        <input type="number" class="form-control form-text" v-model="productModel.qtyOnHand">
      </div>
      <div class="col">
        <button class="btn btn-success" @click="updateProducts">Save</button>
      </div>
    </div>
  </div>

</template>

<script>
import axios from "axios";

export default {
  name: "productItem",
  props: {
    product: Object
  },
  data: function (){
    return{
      editMode: false,
      productModel: {
        manufacturer: this.product.manufacturer,
        name: this.product.name,
        commissionPct: this.product.commissionPct,
        purchasePrice: this.product.purchasePrice,
        qtyOnHand: this.product.qtyOnHand,
        salePrice: this.product.salePrice,
        style: this.product.style,
        productId: this.product.productId
      }
    }
  },
  methods: {
    updateProducts: function(){
      this.editMode = !this.editMode;

      let payload = this.productModel;

      if(this.productModel.manufacturer === this.product.manufacturer){
        delete this.productModel.manufacturer;
      }

      if(this.productModel.name === this.product.name){
        delete this.productModel.name;
      }

      axios({
        method: 'post',
        url: this.$hostname + 'products/update',
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-type': 'application/json'
        },
        data: JSON.stringify(payload)
      }).then(response => {
        console.log(response.data);
        alert("Success");
        this.$emit('update', true);
      }).catch(err => alert(err.response.data.response));
    }
  }
}
</script>

<style scoped>

</style>