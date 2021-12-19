<template>
  <div class="container-fluid">
    <div class="row">
      <div class="col" :class="discountHl">{{discount.discountName}}</div>
      <div class="col" :class="discountHl">{{discount.discountPct}}</div>
      <div class="col">
        <button class="btn btn-primary" :disabled="!isDiscountValid" @click="applyDiscount">Apply</button>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "discountItem",
  data: function(){
    return{
      disabledClassObj: {
        'text-muted': true
      },
      isDiscountValid: false
    }
  },
  props:{
    discount: Object
  },
  methods: {
    applyDiscount: function(){
        this.$emit('discount', this.discount.discountPct);
        this.isDiscountValid = false;
    }
  },
  mounted() {
    if(Date.now() >= new Date(this.discount.beginDate) && Date.now() <= new Date(this.discount.endDate)){
      this.isDiscountValid = true
    }
  },
  computed: {
    discountHl: function(){
      if(this.discountIsValid){
        return {'fw-bold': true};
      }

      return {
        'text-muted': true
      }
    },
    discountIsValid: function(){
      return Date.now() >= new Date(this.discount.beginDate) && Date.now() <= new Date(this.discount.endDate);
    }
  },

}
</script>

<style scoped>

</style>