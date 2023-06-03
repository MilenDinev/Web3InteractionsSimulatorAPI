"use strict";(self.webpackChunkjaxworld_app=self.webpackChunkjaxworld_app||[]).push([[9625],{51620:function(t,e,r){r.d(e,{S:function(){return u}});var n=r(74165),a=r(15861),s=r(15671),c=r(43144),o=r(4110),i=r(42014),u=function(){function t(e,r,c){var u=this;(0,s.Z)(this,t);var p=this;(0,o._)(this,"contractWrapper",void 0),(0,o._)(this,"storage",void 0),(0,o._)(this,"erc1155",void 0),(0,o._)(this,"_chainId",void 0),(0,o._)(this,"transfer",(0,i.du)(function(){var t=(0,a.Z)((0,n.Z)().mark((function t(e,r,a){var s,c=arguments;return(0,n.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return s=c.length>3&&void 0!==c[3]?c[3]:[0],t.abrupt("return",p.erc1155.transfer.prepare(e,r,a,s));case 2:case"end":return t.stop()}}),t)})));return function(e,r,n){return t.apply(this,arguments)}}())),(0,o._)(this,"setApprovalForAll",(0,i.du)(function(){var t=(0,a.Z)((0,n.Z)().mark((function t(e,r){return(0,n.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",u.erc1155.setApprovalForAll.prepare(e,r));case 1:case"end":return t.stop()}}),t)})));return function(e,r){return t.apply(this,arguments)}}())),(0,o._)(this,"airdrop",(0,i.du)(function(){var t=(0,a.Z)((0,n.Z)().mark((function t(e,r){var a,s=arguments;return(0,n.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return a=s.length>2&&void 0!==s[2]?s[2]:[0],t.abrupt("return",p.erc1155.airdrop.prepare(e,r,a));case 2:case"end":return t.stop()}}),t)})));return function(e,r){return t.apply(this,arguments)}}())),this.contractWrapper=e,this.storage=r,this.erc1155=new i.aD(this.contractWrapper,this.storage,c),this._chainId=c}return(0,c.Z)(t,[{key:"chainId",get:function(){return this._chainId}},{key:"onNetworkUpdated",value:function(t){this.contractWrapper.updateSignerOrProvider(t)}},{key:"getAddress",value:function(){return this.contractWrapper.readContract.address}},{key:"get",value:function(){var t=(0,a.Z)((0,n.Z)().mark((function t(e){return(0,n.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",this.erc1155.get(e));case 1:case"end":return t.stop()}}),t,this)})));return function(e){return t.apply(this,arguments)}}()},{key:"totalSupply",value:function(){var t=(0,a.Z)((0,n.Z)().mark((function t(e){return(0,n.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",this.erc1155.totalSupply(e));case 1:case"end":return t.stop()}}),t,this)})));return function(e){return t.apply(this,arguments)}}()},{key:"balanceOf",value:function(){var t=(0,a.Z)((0,n.Z)().mark((function t(e,r){return(0,n.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",this.erc1155.balanceOf(e,r));case 1:case"end":return t.stop()}}),t,this)})));return function(e,r){return t.apply(this,arguments)}}()},{key:"balance",value:function(){var t=(0,a.Z)((0,n.Z)().mark((function t(e){return(0,n.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",this.erc1155.balance(e));case 1:case"end":return t.stop()}}),t,this)})));return function(e){return t.apply(this,arguments)}}()},{key:"isApproved",value:function(){var t=(0,a.Z)((0,n.Z)().mark((function t(e,r){return(0,n.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",this.erc1155.isApproved(e,r));case 1:case"end":return t.stop()}}),t,this)})));return function(e,r){return t.apply(this,arguments)}}()}]),t}()},39625:function(t,e,r){r.r(e),r.d(e,{Pack:function(){return U}});var n=r(1413),a=r(97326),s=r(60136),c=r(29388),o=r(37762),i=r(74165),u=r(15861),p=r(15671),d=r(43144),f=r(4110),l=r(42014),h=r(51620),v=JSON.parse('[{"inputs":[{"internalType":"string","name":"name_","type":"string"},{"internalType":"string","name":"symbol_","type":"string"}],"stateMutability":"nonpayable","type":"constructor"},{"anonymous":false,"inputs":[{"indexed":true,"internalType":"address","name":"owner","type":"address"},{"indexed":true,"internalType":"address","name":"spender","type":"address"},{"indexed":false,"internalType":"uint256","name":"value","type":"uint256"}],"name":"Approval","type":"event"},{"anonymous":false,"inputs":[{"indexed":true,"internalType":"address","name":"from","type":"address"},{"indexed":true,"internalType":"address","name":"to","type":"address"},{"indexed":false,"internalType":"uint256","name":"value","type":"uint256"}],"name":"Transfer","type":"event"},{"inputs":[{"internalType":"address","name":"owner","type":"address"},{"internalType":"address","name":"spender","type":"address"}],"name":"allowance","outputs":[{"internalType":"uint256","name":"","type":"uint256"}],"stateMutability":"view","type":"function"},{"inputs":[{"internalType":"address","name":"spender","type":"address"},{"internalType":"uint256","name":"amount","type":"uint256"}],"name":"approve","outputs":[{"internalType":"bool","name":"","type":"bool"}],"stateMutability":"nonpayable","type":"function"},{"inputs":[{"internalType":"address","name":"account","type":"address"}],"name":"balanceOf","outputs":[{"internalType":"uint256","name":"","type":"uint256"}],"stateMutability":"view","type":"function"},{"inputs":[],"name":"decimals","outputs":[{"internalType":"uint8","name":"","type":"uint8"}],"stateMutability":"view","type":"function"},{"inputs":[{"internalType":"address","name":"spender","type":"address"},{"internalType":"uint256","name":"subtractedValue","type":"uint256"}],"name":"decreaseAllowance","outputs":[{"internalType":"bool","name":"","type":"bool"}],"stateMutability":"nonpayable","type":"function"},{"inputs":[{"internalType":"address","name":"spender","type":"address"},{"internalType":"uint256","name":"addedValue","type":"uint256"}],"name":"increaseAllowance","outputs":[{"internalType":"bool","name":"","type":"bool"}],"stateMutability":"nonpayable","type":"function"},{"inputs":[],"name":"name","outputs":[{"internalType":"string","name":"","type":"string"}],"stateMutability":"view","type":"function"},{"inputs":[],"name":"symbol","outputs":[{"internalType":"string","name":"","type":"string"}],"stateMutability":"view","type":"function"},{"inputs":[],"name":"totalSupply","outputs":[{"internalType":"uint256","name":"","type":"uint256"}],"stateMutability":"view","type":"function"},{"inputs":[{"internalType":"address","name":"to","type":"address"},{"internalType":"uint256","name":"amount","type":"uint256"}],"name":"transfer","outputs":[{"internalType":"bool","name":"","type":"bool"}],"stateMutability":"nonpayable","type":"function"},{"inputs":[{"internalType":"address","name":"from","type":"address"},{"internalType":"address","name":"to","type":"address"},{"internalType":"uint256","name":"amount","type":"uint256"}],"name":"transferFrom","outputs":[{"internalType":"bool","name":"","type":"bool"}],"stateMutability":"nonpayable","type":"function"}]'),y=r(27761),w=r(19560),k=r(18383),m=r(81895),g=r(99094),b=(r(64166),r(79955),r(15267),r(86168),r(7605),r(60862),r(89806),g.z.object({contractAddress:l.ab})),Z=b.extend({quantity:f.A}),x=b.extend({tokenId:l.a8}),W=b.extend({tokenId:l.a8,quantity:l.a8}),A=Z.omit({quantity:!0}).extend({quantityPerReward:f.A}),R=x,C=W.omit({quantity:!0}).extend({quantityPerReward:l.a8}),P=A.extend({totalRewards:l.a8.default("1")}),T=R,_=C.extend({totalRewards:l.a8.default("1")});g.z.object({erc20Rewards:g.z.array(A).default([]),erc721Rewards:g.z.array(R).default([]),erc1155Rewards:g.z.array(C).default([])});var I=g.z.object({erc20Rewards:g.z.array(P).default([]),erc721Rewards:g.z.array(T).default([]),erc1155Rewards:g.z.array(_).default([])}),O=I.extend({packMetadata:f.N,rewardsPerPack:l.a8.default("1"),openStartTime:l.ac.default(new Date)}),S=function(){function t(e,r,n,a,s){(0,p.Z)(this,t);var c=this,o=arguments.length>5&&void 0!==arguments[5]?arguments[5]:new l.dC(e,r,y,a);(0,f._)(this,"featureName",l.dO.name),(0,f._)(this,"contractWrapper",void 0),(0,f._)(this,"storage",void 0),(0,f._)(this,"chainId",void 0),(0,f._)(this,"events",void 0),(0,f._)(this,"open",(0,l.du)(function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){var r,n,a=arguments;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return r=a.length>1&&void 0!==a[1]?a[1]:1,n=a.length>2&&void 0!==a[2]?a[2]:5e5,t.abrupt("return",l.aU.fromContractWrapper({contractWrapper:c.contractWrapper,method:"openPack",args:[e,r],overrides:{gasLimit:n},parse:function(t){var e=w.O$.from(0);try{e=c.contractWrapper.parseLogs("PackOpenRequested",null===t||void 0===t?void 0:t.logs)[0].args.requestId}catch(r){}return{receipt:t,id:e}}}));case 3:case"end":return t.stop()}}),t)})));return function(e){return t.apply(this,arguments)}}())),(0,f._)(this,"claimRewards",(0,l.du)((0,u.Z)((0,i.Z)().mark((function t(){var e,r=arguments;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return e=r.length>0&&void 0!==r[0]?r[0]:5e5,t.abrupt("return",l.aU.fromContractWrapper({contractWrapper:c.contractWrapper,method:"claimRewards",args:[],overrides:{gasLimit:e},parse:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){var r,n;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:if(0!==(r=c.contractWrapper.parseLogs("PackOpened",null===e||void 0===e?void 0:e.logs)).length){t.next=3;break}throw new Error("PackOpened event not found");case 3:return n=r[0].args.rewardUnitsDistributed,t.next=6,c.parseRewards(n);case 6:return t.abrupt("return",t.sent);case 7:case"end":return t.stop()}}),t)})));return function(e){return t.apply(this,arguments)}}()}));case 2:case"end":return t.stop()}}),t)}))))),this.contractWrapper=o,this.storage=n,this.chainId=s,this.events=new l.aP(this.contractWrapper)}return(0,d.Z)(t,[{key:"onNetworkUpdated",value:function(t){this.contractWrapper.updateSignerOrProvider(t)}},{key:"getAddress",value:function(){return this.contractWrapper.readContract.address}},{key:"parseRewards",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){var r,n,a,s,c,u,p;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:r=[],n=[],a=[],s=(0,o.Z)(e),t.prev=4,s.s();case 6:if((c=s.n()).done){t.next=22;break}u=c.value,t.t0=u.tokenType,t.next=0===t.t0?11:1===t.t0?16:2===t.t0?18:20;break;case 11:return t.next=13,(0,l.bW)(this.contractWrapper.getProvider(),u.assetContract);case 13:return p=t.sent,r.push({contractAddress:u.assetContract,quantityPerReward:k.formatUnits(u.totalAmount,p.decimals).toString()}),t.abrupt("break",20);case 16:return n.push({contractAddress:u.assetContract,tokenId:u.tokenId.toString()}),t.abrupt("break",20);case 18:return a.push({contractAddress:u.assetContract,tokenId:u.tokenId.toString(),quantityPerReward:u.totalAmount.toString()}),t.abrupt("break",20);case 20:t.next=6;break;case 22:t.next=27;break;case 24:t.prev=24,t.t1=t.catch(4),s.e(t.t1);case 27:return t.prev=27,s.f(),t.finish(27);case 30:return t.abrupt("return",{erc20Rewards:r,erc721Rewards:n,erc1155Rewards:a});case 31:case"end":return t.stop()}}),t,this,[[4,24,27,30]])})));return function(e){return t.apply(this,arguments)}}()},{key:"addPackOpenEventListener",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){var r=this;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",this.events.addEventListener("PackOpened",function(){var t=(0,u.Z)((0,i.Z)().mark((function t(n){return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.t0=e,t.t1=n.data.packId.toString(),t.t2=n.data.opener,t.next=5,r.parseRewards(n.data.rewardUnitsDistributed);case 5:t.t3=t.sent,(0,t.t0)(t.t1,t.t2,t.t3);case 7:case"end":return t.stop()}}),t)})));return function(e){return t.apply(this,arguments)}}()));case 1:case"end":return t.stop()}}),t,this)})));return function(e){return t.apply(this,arguments)}}()},{key:"canClaimRewards",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){var r;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:if(t.t0=l.dv,t.t1=e,t.t1){t.next=6;break}return t.next=5,this.contractWrapper.getSignerAddress();case 5:t.t1=t.sent;case 6:return t.t2=t.t1,t.next=9,(0,t.t0)(t.t2);case 9:return r=t.sent,t.next=12,this.contractWrapper.readContract.canClaimRewards(r);case 12:return t.abrupt("return",t.sent);case 13:case"end":return t.stop()}}),t,this)})));return function(e){return t.apply(this,arguments)}}()},{key:"openAndClaim",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){var r,n,a,s,c,o=arguments;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return r=o.length>1&&void 0!==o[1]?o[1]:1,n=o.length>2&&void 0!==o[2]?o[2]:5e5,t.next=4,this.contractWrapper.sendTransaction("openPackAndClaimRewards",[e,r,n],{gasLimit:w.O$.from(5e5)});case 4:a=t.sent,s=w.O$.from(0);try{c=this.contractWrapper.parseLogs("PackOpenRequested",null===a||void 0===a?void 0:a.logs),s=c[0].args.requestId}catch(i){}return t.abrupt("return",{receipt:a,id:s});case 8:case"end":return t.stop()}}),t,this)})));return function(e){return t.apply(this,arguments)}}()},{key:"getLinkBalance",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(){return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",this.getLinkContract().balanceOf(this.contractWrapper.readContract.address));case 1:case"end":return t.stop()}}),t,this)})));return function(){return t.apply(this,arguments)}}()},{key:"transferLink",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,this.getLinkContract().transfer(this.contractWrapper.readContract.address,e);case 2:case"end":return t.stop()}}),t,this)})));return function(e){return t.apply(this,arguments)}}()},{key:"getLinkContract",value:function(){var t=l.cU[this.chainId];if(!t)throw new Error("No LINK token address found for chainId ".concat(this.chainId));var e=new l.dC(this.contractWrapper.getSignerOrProvider(),t,v,this.contractWrapper.options);return new l.ap(e,this.storage,this.chainId)}}]),t}(),U=function(t){(0,s.Z)(r,t);var e=(0,c.Z)(r);function r(t,s,c){var d,h;(0,p.Z)(this,r);var v=arguments.length>3&&void 0!==arguments[3]?arguments[3]:{},y=arguments.length>4?arguments[4]:void 0,w=arguments.length>5?arguments[5]:void 0,m=arguments.length>6&&void 0!==arguments[6]?arguments[6]:new l.dC(t,s,y,v.gasless&&"openzeppelin"in v.gasless?(0,n.Z)((0,n.Z)({},v),{},{gasless:(0,n.Z)((0,n.Z)({},v.gasless),{},{openzeppelin:(0,n.Z)((0,n.Z)({},v.gasless.openzeppelin),{},{useEOAForwarder:!0})})}):v);return d=e.call(this,m,c,w),h=(0,a.Z)(d),(0,f._)((0,a.Z)(d),"abi",void 0),(0,f._)((0,a.Z)(d),"metadata",void 0),(0,f._)((0,a.Z)(d),"app",void 0),(0,f._)((0,a.Z)(d),"roles",void 0),(0,f._)((0,a.Z)(d),"encoder",void 0),(0,f._)((0,a.Z)(d),"events",void 0),(0,f._)((0,a.Z)(d),"estimator",void 0),(0,f._)((0,a.Z)(d),"royalties",void 0),(0,f._)((0,a.Z)(d),"interceptor",void 0),(0,f._)((0,a.Z)(d),"owner",void 0),(0,f._)((0,a.Z)(d),"_vrf",void 0),(0,f._)((0,a.Z)(d),"create",(0,l.du)(function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){var r;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,d.contractWrapper.getSignerAddress();case 2:return r=t.sent,t.abrupt("return",d.createTo.prepare(r,e));case 4:case"end":return t.stop()}}),t)})));return function(e){return t.apply(this,arguments)}}())),(0,f._)((0,a.Z)(d),"addPackContents",(0,l.du)(function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e,r){var n,a,s,c,o;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,d.contractWrapper.getSignerAddress();case 2:return n=t.sent,t.next=5,I.parseAsync(r);case 5:return a=t.sent,t.next=8,d.toPackContentArgs(a);case 8:return s=t.sent,c=s.contents,o=s.numOfRewardUnits,t.abrupt("return",l.aU.fromContractWrapper({contractWrapper:d.contractWrapper,method:"addPackContents",args:[e,c,o,n],parse:function(t){var e=d.contractWrapper.parseLogs("PackUpdated",null===t||void 0===t?void 0:t.logs);if(0===e.length)throw new Error("PackUpdated event not found");var r=e[0].args.packId;return{id:r,receipt:t,data:function(){return d.erc1155.get(r)}}}}));case 12:case"end":return t.stop()}}),t)})));return function(e,r){return t.apply(this,arguments)}}())),(0,f._)((0,a.Z)(d),"createTo",(0,l.du)(function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e,r){var n,a,s,c,o,u,p,f,h;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,(0,l.dK)(r.packMetadata,d.storage);case 2:return n=t.sent,t.next=5,O.parseAsync(r);case 5:return a=t.sent,s=a.erc20Rewards,c=a.erc721Rewards,o=a.erc1155Rewards,u={erc20Rewards:s,erc721Rewards:c,erc1155Rewards:o},t.next=10,d.toPackContentArgs(u);case 10:return p=t.sent,f=p.contents,h=p.numOfRewardUnits,t.t0=l.aU,t.t1=d.contractWrapper,t.t2=f,t.t3=h,t.t4=n,t.t5=a.openStartTime,t.t6=a.rewardsPerPack,t.next=22,(0,l.dv)(e);case 22:return t.t7=t.sent,t.t8=[t.t2,t.t3,t.t4,t.t5,t.t6,t.t7],t.t9=function(t){var e=d.contractWrapper.parseLogs("PackCreated",null===t||void 0===t?void 0:t.logs);if(0===e.length)throw new Error("PackCreated event not found");var r=e[0].args.packId;return{id:r,receipt:t,data:function(){return d.erc1155.get(r)}}},t.t10={contractWrapper:t.t1,method:"createPack",args:t.t8,parse:t.t9},t.abrupt("return",t.t0.fromContractWrapper.call(t.t0,t.t10));case 27:case"end":return t.stop()}}),t)})));return function(e,r){return t.apply(this,arguments)}}())),(0,f._)((0,a.Z)(d),"open",(0,l.du)(function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){var r,n,a=arguments;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:if(r=a.length>1&&void 0!==a[1]?a[1]:1,n=a.length>2&&void 0!==a[2]?a[2]:5e5,!h._vrf){t.next=4;break}throw new Error("This contract is using Chainlink VRF, use `contract.vrf.open()` or `contract.vrf.openAndClaim()` instead");case 4:return t.abrupt("return",l.aU.fromContractWrapper({contractWrapper:h.contractWrapper,method:"openPack",args:[e,r],overrides:{gasLimit:n},parse:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){var r,n,a,s,c,u,p,d,f;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:if(0!==(r=h.contractWrapper.parseLogs("PackOpened",null===e||void 0===e?void 0:e.logs)).length){t.next=3;break}throw new Error("PackOpened event not found");case 3:n=r[0].args.rewardUnitsDistributed,a=[],s=[],c=[],u=(0,o.Z)(n),t.prev=8,u.s();case 10:if((p=u.n()).done){t.next=26;break}d=p.value,t.t0=d.tokenType,t.next=0===t.t0?15:1===t.t0?20:2===t.t0?22:24;break;case 15:return t.next=17,(0,l.bW)(h.contractWrapper.getProvider(),d.assetContract);case 17:return f=t.sent,a.push({contractAddress:d.assetContract,quantityPerReward:k.formatUnits(d.totalAmount,f.decimals).toString()}),t.abrupt("break",24);case 20:return s.push({contractAddress:d.assetContract,tokenId:d.tokenId.toString()}),t.abrupt("break",24);case 22:return c.push({contractAddress:d.assetContract,tokenId:d.tokenId.toString(),quantityPerReward:d.totalAmount.toString()}),t.abrupt("break",24);case 24:t.next=10;break;case 26:t.next=31;break;case 28:t.prev=28,t.t1=t.catch(8),u.e(t.t1);case 31:return t.prev=31,u.f(),t.finish(31);case 34:return t.abrupt("return",{erc20Rewards:a,erc721Rewards:s,erc1155Rewards:c});case 35:case"end":return t.stop()}}),t,null,[[8,28,31,34]])})));return function(e){return t.apply(this,arguments)}}()}));case 5:case"end":return t.stop()}}),t)})));return function(e){return t.apply(this,arguments)}}())),d.abi=l.e.parse(y||[]),d.metadata=new l.ai(d.contractWrapper,l.dP,d.storage),d.app=new l.aW(d.contractWrapper,d.metadata,d.storage),d.roles=new l.aj(d.contractWrapper,r.contractRoles),d.royalties=new l.ak(d.contractWrapper,d.metadata),d.encoder=new l.ah(d.contractWrapper),d.estimator=new l.aO(d.contractWrapper),d.events=new l.aP(d.contractWrapper),d.interceptor=new l.aQ(d.contractWrapper),d.owner=new l.aT(d.contractWrapper),d._vrf=d.detectVrf(),d}return(0,d.Z)(r,[{key:"vrf",get:function(){return(0,l.bN)(this._vrf,l.dO)}},{key:"onNetworkUpdated",value:function(t){var e;this.contractWrapper.updateSignerOrProvider(t),null===(e=this._vrf)||void 0===e||e.onNetworkUpdated(t)}},{key:"getAddress",value:function(){return this.contractWrapper.readContract.address}},{key:"get",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",this.erc1155.get(e));case 1:case"end":return t.stop()}}),t,this)})));return function(e){return t.apply(this,arguments)}}()},{key:"getAll",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",this.erc1155.getAll(e));case 1:case"end":return t.stop()}}),t,this)})));return function(e){return t.apply(this,arguments)}}()},{key:"getOwned",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",this.erc1155.getOwned(e));case 1:case"end":return t.stop()}}),t,this)})));return function(e){return t.apply(this,arguments)}}()},{key:"getTotalCount",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(){return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",this.erc1155.totalCount());case 1:case"end":return t.stop()}}),t,this)})));return function(){return t.apply(this,arguments)}}()},{key:"isTransferRestricted",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(){var e;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,this.contractWrapper.readContract.hasRole((0,l.bq)("transfer"),m.d);case 2:return e=t.sent,t.abrupt("return",!e);case 4:case"end":return t.stop()}}),t,this)})));return function(){return t.apply(this,arguments)}}()},{key:"getPackContents",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){var r,n,a,s,c,o,u,p,d,f,h,v;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.next=2,this.contractWrapper.readContract.getPackContents(e);case 2:r=t.sent,n=r.contents,a=r.perUnitAmounts,s=[],c=[],o=[],u=0;case 9:if(!(u<n.length)){t.next=29;break}p=n[u],d=a[u],t.t0=p.tokenType,t.next=0===t.t0?15:1===t.t0?22:2===t.t0?24:26;break;case 15:return t.next=17,(0,l.bW)(this.contractWrapper.getProvider(),p.assetContract);case 17:return f=t.sent,h=k.formatUnits(d,f.decimals),v=k.formatUnits(w.O$.from(p.totalAmount).div(d),f.decimals),s.push({contractAddress:p.assetContract,quantityPerReward:h,totalRewards:v}),t.abrupt("break",26);case 22:return c.push({contractAddress:p.assetContract,tokenId:p.tokenId.toString()}),t.abrupt("break",26);case 24:return o.push({contractAddress:p.assetContract,tokenId:p.tokenId.toString(),quantityPerReward:d.toString(),totalRewards:w.O$.from(p.totalAmount).div(d).toString()}),t.abrupt("break",26);case 26:u++,t.next=9;break;case 29:return t.abrupt("return",{erc20Rewards:s,erc721Rewards:c,erc1155Rewards:o});case 30:case"end":return t.stop()}}),t,this)})));return function(e){return t.apply(this,arguments)}}()},{key:"toPackContentArgs",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e){var r,n,a,s,c,u,p,d,f,h,v,y,k,m,g,b,Z,x;return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return r=[],n=[],a=e.erc20Rewards,s=e.erc721Rewards,c=e.erc1155Rewards,u=this.contractWrapper.getProvider(),t.next=6,this.contractWrapper.getSignerAddress();case 6:p=t.sent,d=(0,o.Z)(a),t.prev=8,d.s();case 10:if((f=d.n()).done){t.next=25;break}return h=f.value,t.next=14,(0,l.bV)(u,h.quantityPerReward,h.contractAddress);case 14:return v=t.sent,y=v.mul(h.totalRewards),t.next=18,(0,l.b_)(this.contractWrapper,h.contractAddress,y);case 18:if(t.sent){t.next=21;break}throw new Error('ERC20 token with contract address "'.concat(h.contractAddress,'" does not have enough allowance to transfer.\n\nYou can set allowance to the multiwrap contract to transfer these tokens by running:\n\nawait sdk.getToken("').concat(h.contractAddress,'").setAllowance("').concat(this.getAddress(),'", ').concat(y,");\n\n"));case 21:n.push(h.totalRewards),r.push({assetContract:h.contractAddress,tokenType:0,totalAmount:y,tokenId:0});case 23:t.next=10;break;case 25:t.next=30;break;case 27:t.prev=27,t.t0=t.catch(8),d.e(t.t0);case 30:return t.prev=30,d.f(),t.finish(30);case 33:k=(0,o.Z)(s),t.prev=34,k.s();case 36:if((m=k.n()).done){t.next=47;break}return g=m.value,t.next=40,(0,l.dy)(this.contractWrapper.getProvider(),this.getAddress(),g.contractAddress,g.tokenId,p);case 40:if(t.sent){t.next=43;break}throw new Error('ERC721 token "'.concat(g.tokenId,'" with contract address "').concat(g.contractAddress,'" is not approved for transfer.\n\nYou can give approval the multiwrap contract to transfer this token by running:\n\nawait sdk.getNFTCollection("').concat(g.contractAddress,'").setApprovalForToken("').concat(this.getAddress(),'", ').concat(g.tokenId,");\n\n"));case 43:n.push("1"),r.push({assetContract:g.contractAddress,tokenType:1,totalAmount:1,tokenId:g.tokenId});case 45:t.next=36;break;case 47:t.next=52;break;case 49:t.prev=49,t.t1=t.catch(34),k.e(t.t1);case 52:return t.prev=52,k.f(),t.finish(52);case 55:b=(0,o.Z)(c),t.prev=56,b.s();case 58:if((Z=b.n()).done){t.next=69;break}return x=Z.value,t.next=62,(0,l.dy)(this.contractWrapper.getProvider(),this.getAddress(),x.contractAddress,x.tokenId,p);case 62:if(t.sent){t.next=65;break}throw new Error('ERC1155 token "'.concat(x.tokenId,'" with contract address "').concat(x.contractAddress,'" is not approved for transfer.\n\nYou can give approval the multiwrap contract to transfer this token by running:\n\nawait sdk.getEdition("').concat(x.contractAddress,'").setApprovalForAll("').concat(this.getAddress(),'", true);\n\n'));case 65:n.push(x.totalRewards),r.push({assetContract:x.contractAddress,tokenType:2,totalAmount:w.O$.from(x.quantityPerReward).mul(w.O$.from(x.totalRewards)),tokenId:x.tokenId});case 67:t.next=58;break;case 69:t.next=74;break;case 71:t.prev=71,t.t2=t.catch(56),b.e(t.t2);case 74:return t.prev=74,b.f(),t.finish(74);case 77:return t.abrupt("return",{contents:r,numOfRewardUnits:n});case 78:case"end":return t.stop()}}),t,this,[[8,27,30,33],[34,49,52,55],[56,71,74,77]])})));return function(e){return t.apply(this,arguments)}}()},{key:"prepare",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e,r,n){return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",l.aU.fromContractWrapper({contractWrapper:this.contractWrapper,method:e,args:r,overrides:n}));case 1:case"end":return t.stop()}}),t,this)})));return function(e,r,n){return t.apply(this,arguments)}}()},{key:"call",value:function(){var t=(0,u.Z)((0,i.Z)().mark((function t(e,r,n){return(0,i.Z)().wrap((function(t){for(;;)switch(t.prev=t.next){case 0:return t.abrupt("return",this.contractWrapper.call(e,r,n));case 1:case"end":return t.stop()}}),t,this)})));return function(e,r,n){return t.apply(this,arguments)}}()},{key:"detectVrf",value:function(){if((0,l.bO)(this.contractWrapper,"PackVRF"))return new S(this.contractWrapper.getSignerOrProvider(),this.contractWrapper.readContract.address,this.storage,this.contractWrapper.options,this.chainId)}}]),r}(h.S);(0,f._)(U,"contractRoles",["admin","minter","asset","transfer"])}}]);